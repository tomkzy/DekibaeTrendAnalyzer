using DekibaeTrendAnalyzer.Models;
using DekibaeTrendAnalyzer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DekibaeTrendAnalyzer.Forms
{
    public partial class ConditionForm : Form
    {

        public struct ConditionStatus
        {
            int Index;
            string Name;
            bool Status;

            public ConditionStatus(int i, string name, bool status)
            {
                Index = i;
                Name = name;
                Status = status;
            }
            
        };

        BindingList<ConditionStatus> conditionStatuses = new BindingList<ConditionStatus>();


        BindingList<ConditionSet> conditionSetList = new BindingList<ConditionSet>();

        public ConditionForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeData();

        }

        private void InitializeUI()
        {
            this.Text = "条件設定フォーム";

            dataGridView.CellFormatting += DataGridView_CellFormatting;
            GetConditionInfo();
            dataGridView.DataSource = conditionStatuses;

            // ボタン初期化
            btnAddCondition.Click += BtnAdd_Click;
            btnDeleteCondition.Click += BtnDelete_Click;
        }

        private void GetConditionInfo()
        {

            for (int cs_cnt = 0; cs_cnt < conditionSetList.Count; cs_cnt++)
                {
                    ConditionSet cs = conditionSetList[cs_cnt];
                    bool status = ConditionSetValidator.IsSatisfied(cs);
                    ConditionStatus css = new ConditionStatus(cs_cnt, cs.Name, status);
                    conditionStatuses.Add(css);
                }
            }

        private void InitializeData()
        {
            conditionSetList.Add(new ConditionSet());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // 追加済の条件がすべて「OK」の場合のみ追加する
            if (CheckSettingState())
            {
                int nextIndex = dataGridView.Rows.Count + 1;
                dataGridView.Rows.Add(nextIndex.ToString(), "新しい条件", "NG");
            }
            else
            {
                MessageBox.Show("作成済みの全ての条件が「OK」の場合のみ新しい条件を追加できます。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                UpdateIndexes();
            }
        }

        private void UpdateIndexes()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells["Index"].Value = (i + 1).ToString();
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Result")
            {
                string value = e.Value?.ToString();
                if (value == "OK")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.DarkGreen;
                }
                else if (value == "NG")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 条件の入力状況をチェック
        /// </summary>
        /// <returns></returns>
        private bool CheckSettingState()
        {
            if (dataGridView.Rows.Count <= 1)
            {
                return true;
            }
            // すべての条件が「OK」の場合、trueを返す
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Result"].Value?.ToString() != "OK")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
