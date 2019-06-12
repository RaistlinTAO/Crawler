namespace Crawler.UI
{
    partial class frmShow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWebSite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeedURL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQueueNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinishedQueue = new System.Windows.Forms.Label();
            this.lsvFinished = new System.Windows.Forms.ListView();
            this.lsvQueue = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFinishedQueue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQueueNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSeedURL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWebSite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website:";
            // 
            // txtWebSite
            // 
            this.txtWebSite.AutoSize = true;
            this.txtWebSite.Location = new System.Drawing.Point(98, 25);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(0, 13);
            this.txtWebSite.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seed URL:";
            // 
            // txtSeedURL
            // 
            this.txtSeedURL.AutoSize = true;
            this.txtSeedURL.Location = new System.Drawing.Point(98, 48);
            this.txtSeedURL.Name = "txtSeedURL";
            this.txtSeedURL.Size = new System.Drawing.Size(0, 13);
            this.txtSeedURL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL Queue:";
            // 
            // txtQueueNum
            // 
            this.txtQueueNum.AutoSize = true;
            this.txtQueueNum.Location = new System.Drawing.Point(122, 73);
            this.txtQueueNum.Name = "txtQueueNum";
            this.txtQueueNum.Size = new System.Drawing.Size(0, 13);
            this.txtQueueNum.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "URL Visited And Stored:";
            // 
            // txtFinishedQueue
            // 
            this.txtFinishedQueue.AutoSize = true;
            this.txtFinishedQueue.Location = new System.Drawing.Point(476, 73);
            this.txtFinishedQueue.Name = "txtFinishedQueue";
            this.txtFinishedQueue.Size = new System.Drawing.Size(0, 13);
            this.txtFinishedQueue.TabIndex = 7;
            // 
            // lsvFinished
            // 
            this.lsvFinished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvFinished.FullRowSelect = true;
            this.lsvFinished.GridLines = true;
            this.lsvFinished.Location = new System.Drawing.Point(12, 135);
            this.lsvFinished.MultiSelect = false;
            this.lsvFinished.Name = "lsvFinished";
            this.lsvFinished.Size = new System.Drawing.Size(693, 194);
            this.lsvFinished.TabIndex = 1;
            this.lsvFinished.UseCompatibleStateImageBehavior = false;
            this.lsvFinished.View = System.Windows.Forms.View.Details;
            // 
            // lsvQueue
            // 
            this.lsvQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lsvQueue.FullRowSelect = true;
            this.lsvQueue.GridLines = true;
            this.lsvQueue.Location = new System.Drawing.Point(12, 348);
            this.lsvQueue.MultiSelect = false;
            this.lsvQueue.Name = "lsvQueue";
            this.lsvQueue.Size = new System.Drawing.Size(693, 201);
            this.lsvQueue.TabIndex = 2;
            this.lsvQueue.UseCompatibleStateImageBehavior = false;
            this.lsvQueue.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Finished Queue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Unvisited Queue:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "WebPage";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Is Mobile?";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Stored";
            this.columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "WebPage";
            this.columnHeader4.Width = 450;
            // 
            // frmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvQueue);
            this.Controls.Add(this.lsvFinished);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmShow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSeedURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtWebSite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtFinishedQueue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtQueueNum;
        private System.Windows.Forms.ListView lsvFinished;
        private System.Windows.Forms.ListView lsvQueue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}