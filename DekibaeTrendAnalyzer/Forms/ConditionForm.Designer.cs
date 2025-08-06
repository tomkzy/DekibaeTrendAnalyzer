namespace DekibaeTrendAnalyzer.Forms
{
    partial class ConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCondition = new System.Windows.Forms.TableLayoutPanel();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnDeleteCondition = new System.Windows.Forms.Button();
            this.btnAddCondition = new System.Windows.Forms.Button();
            this.panelConditionList = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelConditionList = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStartAggregation = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpCondition.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelConditionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpCondition, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1898, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpCondition
            // 
            this.tlpCondition.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCondition.ColumnCount = 2;
            this.tlpCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29279F));
            this.tlpCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.70721F));
            this.tlpCondition.Controls.Add(this.panelList, 0, 0);
            this.tlpCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCondition.Location = new System.Drawing.Point(3, 191);
            this.tlpCondition.Name = "tlpCondition";
            this.tlpCondition.RowCount = 1;
            this.tlpCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCondition.Size = new System.Drawing.Size(1892, 830);
            this.tlpCondition.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.btnDeleteCondition);
            this.panelList.Controls.Add(this.btnAddCondition);
            this.panelList.Controls.Add(this.panelConditionList);
            this.panelList.Controls.Add(this.labelConditionList);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(4, 4);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(604, 822);
            this.panelList.TabIndex = 0;
            // 
            // btnDeleteCondition
            // 
            this.btnDeleteCondition.Location = new System.Drawing.Point(137, 516);
            this.btnDeleteCondition.Name = "btnDeleteCondition";
            this.btnDeleteCondition.Size = new System.Drawing.Size(109, 34);
            this.btnDeleteCondition.TabIndex = 3;
            this.btnDeleteCondition.Text = "削除";
            this.btnDeleteCondition.UseVisualStyleBackColor = true;
            // 
            // btnAddCondition
            // 
            this.btnAddCondition.Location = new System.Drawing.Point(22, 516);
            this.btnAddCondition.Name = "btnAddCondition";
            this.btnAddCondition.Size = new System.Drawing.Size(109, 34);
            this.btnAddCondition.TabIndex = 2;
            this.btnAddCondition.Text = "追加";
            this.btnAddCondition.UseVisualStyleBackColor = true;
            // 
            // panelConditionList
            // 
            this.panelConditionList.Controls.Add(this.dataGridView);
            this.panelConditionList.Location = new System.Drawing.Point(15, 36);
            this.panelConditionList.Name = "panelConditionList";
            this.panelConditionList.Size = new System.Drawing.Size(568, 457);
            this.panelConditionList.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ConditionName,
            this.SettingStatus});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(568, 457);
            this.dataGridView.TabIndex = 0;
            // 
            // labelConditionList
            // 
            this.labelConditionList.AutoSize = true;
            this.labelConditionList.Location = new System.Drawing.Point(0, 0);
            this.labelConditionList.Name = "labelConditionList";
            this.labelConditionList.Size = new System.Drawing.Size(116, 18);
            this.labelConditionList.TabIndex = 0;
            this.labelConditionList.Text = "集計条件一覧";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnCancel);
            this.panelMenu.Controls.Add(this.btnStartAggregation);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1892, 182);
            this.panelMenu.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStartAggregation
            // 
            this.btnStartAggregation.Location = new System.Drawing.Point(19, 29);
            this.btnStartAggregation.Name = "btnStartAggregation";
            this.btnStartAggregation.Size = new System.Drawing.Size(142, 45);
            this.btnStartAggregation.TabIndex = 0;
            this.btnStartAggregation.Text = "集計実行";
            this.btnStartAggregation.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Index.Frozen = true;
            this.Index.HeaderText = "No";
            this.Index.MinimumWidth = 8;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 80;
            // 
            // ConditionName
            // 
            this.ConditionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ConditionName.Frozen = true;
            this.ConditionName.HeaderText = "条件名";
            this.ConditionName.MinimumWidth = 8;
            this.ConditionName.Name = "ConditionName";
            this.ConditionName.ReadOnly = true;
            this.ConditionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ConditionName.Width = 120;
            // 
            // SettingStatus
            // 
            this.SettingStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SettingStatus.HeaderText = "設定状況";
            this.SettingStatus.MinimumWidth = 8;
            this.SettingStatus.Name = "SettingStatus";
            this.SettingStatus.ReadOnly = true;
            this.SettingStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SettingStatus.Width = 120;
            // 
            // ConditionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConditionForm";
            this.Text = "ConditionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpCondition.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.panelConditionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpCondition;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label labelConditionList;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStartAggregation;
        private System.Windows.Forms.Panel panelConditionList;
        private System.Windows.Forms.Button btnDeleteCondition;
        private System.Windows.Forms.Button btnAddCondition;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingStatus;
    }
}