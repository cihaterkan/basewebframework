﻿namespace SPSUtil.Moudles
{
    partial class frmDataSendTask
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveSendText = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnGenerateTestData = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.btnLoadExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ssBottom = new System.Windows.Forms.StatusStrip();
            this.opfLoadExcel = new System.Windows.Forms.OpenFileDialog();
            this.sfdSendText = new System.Windows.Forms.SaveFileDialog();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splitContainer1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(880, 385);
            this.pnlMain.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(880, 385);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(880, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveSendText);
            this.panel1.Controls.Add(this.btnSendData);
            this.panel1.Controls.Add(this.btnGenerateTestData);
            this.panel1.Controls.Add(this.txturl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveSendText
            // 
            this.btnSaveSendText.Location = new System.Drawing.Point(573, 33);
            this.btnSaveSendText.Name = "btnSaveSendText";
            this.btnSaveSendText.Size = new System.Drawing.Size(104, 21);
            this.btnSaveSendText.TabIndex = 4;
            this.btnSaveSendText.Text = "生成发送链接包";
            this.btnSaveSendText.UseVisualStyleBackColor = true;
            this.btnSaveSendText.Click += new System.EventHandler(this.btnSaveSendText_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(793, 33);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 21);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "发送数据";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnGenerateTestData
            // 
            this.btnGenerateTestData.Location = new System.Drawing.Point(683, 33);
            this.btnGenerateTestData.Name = "btnGenerateTestData";
            this.btnGenerateTestData.Size = new System.Drawing.Size(104, 21);
            this.btnGenerateTestData.TabIndex = 2;
            this.btnGenerateTestData.Text = "生成测试链接";
            this.btnGenerateTestData.UseVisualStyleBackColor = true;
            this.btnGenerateTestData.Click += new System.EventHandler(this.button1_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(91, 9);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(777, 21);
            this.txturl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送Url模版 ： ";
            // 
            // tsTop
            // 
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadExcel,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(880, 25);
            this.tsTop.TabIndex = 10;
            this.tsTop.Text = "toolStrip1";
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Image = global::SPSUtil.Properties.Resources.page_excel;
            this.btnLoadExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(81, 22);
            this.btnLoadExcel.Text = "加载Excel";
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::SPSUtil.Properties.Resources.page_white_text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton2.Text = "加载Text";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::SPSUtil.Properties.Resources.page_edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "数据加载配置";
            // 
            // ssBottom
            // 
            this.ssBottom.Location = new System.Drawing.Point(0, 410);
            this.ssBottom.Name = "ssBottom";
            this.ssBottom.Size = new System.Drawing.Size(880, 22);
            this.ssBottom.TabIndex = 9;
            this.ssBottom.Text = "statusStrip1";
            // 
            // opfLoadExcel
            // 
            this.opfLoadExcel.Filter = "Excel 97-2003 File|*.xls";
            // 
            // frmDataSendTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 432);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.ssBottom);
            this.Name = "frmDataSendTask";
            this.Text = "批量发送数据";
            this.pnlMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.StatusStrip ssBottom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnLoadExcel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnGenerateTestData;
        private System.Windows.Forms.OpenFileDialog opfLoadExcel;
        private System.Windows.Forms.Button btnSaveSendText;
        private System.Windows.Forms.SaveFileDialog sfdSendText;
    }
}