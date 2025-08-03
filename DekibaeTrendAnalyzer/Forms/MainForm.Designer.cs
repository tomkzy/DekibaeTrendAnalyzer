namespace DekibaeTrendAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTop = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelConditions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewAggregation = new System.Windows.Forms.Button();
            this.btnLoadAggregationFile = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMatrix, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelGraph, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelTop, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1898, 1024);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // tableLayoutPanelMatrix
            // 
            this.tableLayoutPanelMatrix.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMatrix.ColumnCount = 2;
            this.tableLayoutPanelMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMatrix.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanelMatrix.Name = "tableLayoutPanelMatrix";
            this.tableLayoutPanelMatrix.RowCount = 1;
            this.tableLayoutPanelMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMatrix.Size = new System.Drawing.Size(1892, 356);
            this.tableLayoutPanelMatrix.TabIndex = 0;
            // 
            // panelGraph
            // 
            this.panelGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(3, 665);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(1892, 356);
            this.panelGraph.TabIndex = 1;
            // 
            // flowLayoutPanelTop
            // 
            this.flowLayoutPanelTop.Controls.Add(this.panelMenu);
            this.flowLayoutPanelTop.Controls.Add(this.panelConditions);
            this.flowLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            this.flowLayoutPanelTop.Size = new System.Drawing.Size(1892, 294);
            this.flowLayoutPanelTop.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnLoadAggregationFile);
            this.panelMenu.Controls.Add(this.btnNewAggregation);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(363, 291);
            this.panelMenu.TabIndex = 0;
            // 
            // panelConditions
            // 
            this.panelConditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConditions.Location = new System.Drawing.Point(372, 3);
            this.panelConditions.Name = "panelConditions";
            this.panelConditions.Size = new System.Drawing.Size(365, 291);
            this.panelConditions.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "メニュー";
            // 
            // btnNewAggregation
            // 
            this.btnNewAggregation.Location = new System.Drawing.Point(8, 38);
            this.btnNewAggregation.Name = "btnNewAggregation";
            this.btnNewAggregation.Size = new System.Drawing.Size(115, 37);
            this.btnNewAggregation.TabIndex = 1;
            this.btnNewAggregation.Text = "新規集計\r\n";
            this.btnNewAggregation.UseVisualStyleBackColor = true;
            this.btnNewAggregation.Click += new System.EventHandler(this.btnNewAggregation_Click);
            // 
            // btnLoadAggregationFile
            // 
            this.btnLoadAggregationFile.Location = new System.Drawing.Point(8, 81);
            this.btnLoadAggregationFile.Name = "btnLoadAggregationFile";
            this.btnLoadAggregationFile.Size = new System.Drawing.Size(180, 37);
            this.btnLoadAggregationFile.TabIndex = 2;
            this.btnLoadAggregationFile.Text = "集計済みファイル読込";
            this.btnLoadAggregationFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelTop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMatrix;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelConditions;
        private System.Windows.Forms.Button btnLoadAggregationFile;
        private System.Windows.Forms.Button btnNewAggregation;
        private System.Windows.Forms.Label label1;
    }
}

