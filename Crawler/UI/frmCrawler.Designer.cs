namespace Crawler.UI
{
    partial class frmCrawler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrawler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClassifier = new System.Windows.Forms.Button();
            this.cmdShow = new System.Windows.Forms.Button();
            this.cmdArff = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.txtMaxThreads = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxpages = new System.Windows.Forms.Label();
            this.txtPoliteness = new System.Windows.Forms.Label();
            this.txtSeedURL = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCurrentStorage = new System.Windows.Forms.Label();
            this.txtCurrentURL = new System.Windows.Forms.Label();
            this.txtStoredNum = new System.Windows.Forms.Label();
            this.txtVisitedNum = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQueueNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCopyRight = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdClassifier);
            this.groupBox1.Controls.Add(this.cmdShow);
            this.groupBox1.Controls.Add(this.cmdArff);
            this.groupBox1.Controls.Add(this.cmdAbout);
            this.groupBox1.Controls.Add(this.txtMaxThreads);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaxpages);
            this.groupBox1.Controls.Add(this.txtPoliteness);
            this.groupBox1.Controls.Add(this.txtSeedURL);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmdStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // cmdClassifier
            // 
            this.cmdClassifier.Location = new System.Drawing.Point(512, 106);
            this.cmdClassifier.Name = "cmdClassifier";
            this.cmdClassifier.Size = new System.Drawing.Size(120, 23);
            this.cmdClassifier.TabIndex = 17;
            this.cmdClassifier.Text = "&Correct Classifier";
            this.cmdClassifier.UseVisualStyleBackColor = true;
            this.cmdClassifier.Click += new System.EventHandler(this.cmdClassifier_Click);
            // 
            // cmdShow
            // 
            this.cmdShow.Enabled = false;
            this.cmdShow.Location = new System.Drawing.Point(386, 106);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(120, 23);
            this.cmdShow.TabIndex = 16;
            this.cmdShow.Text = "Show &Details";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // cmdArff
            // 
            this.cmdArff.Enabled = false;
            this.cmdArff.Location = new System.Drawing.Point(638, 106);
            this.cmdArff.Name = "cmdArff";
            this.cmdArff.Size = new System.Drawing.Size(120, 23);
            this.cmdArff.TabIndex = 15;
            this.cmdArff.Text = "&Generate  Arff";
            this.cmdArff.UseVisualStyleBackColor = true;
            this.cmdArff.Click += new System.EventHandler(this.cmdArff_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.Location = new System.Drawing.Point(47, 106);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(120, 23);
            this.cmdAbout.TabIndex = 14;
            this.cmdAbout.Text = "&About";
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // txtMaxThreads
            // 
            this.txtMaxThreads.AutoSize = true;
            this.txtMaxThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxThreads.Location = new System.Drawing.Point(670, 23);
            this.txtMaxThreads.Name = "txtMaxThreads";
            this.txtMaxThreads.Size = new System.Drawing.Size(19, 13);
            this.txtMaxThreads.TabIndex = 13;
            this.txtMaxThreads.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max Threads:";
            // 
            // txtMaxpages
            // 
            this.txtMaxpages.AutoSize = true;
            this.txtMaxpages.Location = new System.Drawing.Point(375, 23);
            this.txtMaxpages.Name = "txtMaxpages";
            this.txtMaxpages.Size = new System.Drawing.Size(19, 13);
            this.txtMaxpages.TabIndex = 11;
            this.txtMaxpages.Text = "20";
            // 
            // txtPoliteness
            // 
            this.txtPoliteness.AutoSize = true;
            this.txtPoliteness.Location = new System.Drawing.Point(87, 23);
            this.txtPoliteness.Name = "txtPoliteness";
            this.txtPoliteness.Size = new System.Drawing.Size(19, 13);
            this.txtPoliteness.TabIndex = 10;
            this.txtPoliteness.Text = "10";
            // 
            // txtSeedURL
            // 
            this.txtSeedURL.AutoSize = true;
            this.txtSeedURL.Location = new System.Drawing.Point(120, 49);
            this.txtSeedURL.Name = "txtSeedURL";
            this.txtSeedURL.Size = new System.Drawing.Size(0, 13);
            this.txtSeedURL.TabIndex = 9;
            // 
            // txtPosition
            // 
            this.txtPosition.AutoSize = true;
            this.txtPosition.Location = new System.Drawing.Point(120, 78);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(0, 13);
            this.txtPosition.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Storage Position:";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(173, 106);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(120, 23);
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "&Start Crawler";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seed url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maxpages:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Politeness:";
            // 
            // lstLog
            // 
            this.lstLog.Enabled = false;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(13, 283);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(764, 186);
            this.lstLog.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCurrentStorage);
            this.groupBox2.Controls.Add(this.txtCurrentURL);
            this.groupBox2.Controls.Add(this.txtStoredNum);
            this.groupBox2.Controls.Add(this.txtVisitedNum);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQueueNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job Status";
            // 
            // txtCurrentStorage
            // 
            this.txtCurrentStorage.AutoSize = true;
            this.txtCurrentStorage.Location = new System.Drawing.Point(142, 70);
            this.txtCurrentStorage.Name = "txtCurrentStorage";
            this.txtCurrentStorage.Size = new System.Drawing.Size(0, 13);
            this.txtCurrentStorage.TabIndex = 11;
            // 
            // txtCurrentURL
            // 
            this.txtCurrentURL.AutoSize = true;
            this.txtCurrentURL.Location = new System.Drawing.Point(142, 45);
            this.txtCurrentURL.Name = "txtCurrentURL";
            this.txtCurrentURL.Size = new System.Drawing.Size(0, 13);
            this.txtCurrentURL.TabIndex = 9;
            // 
            // txtStoredNum
            // 
            this.txtStoredNum.AutoSize = true;
            this.txtStoredNum.Location = new System.Drawing.Point(664, 20);
            this.txtStoredNum.Name = "txtStoredNum";
            this.txtStoredNum.Size = new System.Drawing.Size(13, 13);
            this.txtStoredNum.TabIndex = 8;
            this.txtStoredNum.Text = "0";
            // 
            // txtVisitedNum
            // 
            this.txtVisitedNum.AutoSize = true;
            this.txtVisitedNum.Location = new System.Drawing.Point(400, 20);
            this.txtVisitedNum.Name = "txtVisitedNum";
            this.txtVisitedNum.Size = new System.Drawing.Size(13, 13);
            this.txtVisitedNum.TabIndex = 7;
            this.txtVisitedNum.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "URL Stored:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Current Storage File:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Current URL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "URL Visited:";
            // 
            // txtQueueNum
            // 
            this.txtQueueNum.AutoSize = true;
            this.txtQueueNum.Location = new System.Drawing.Point(99, 20);
            this.txtQueueNum.Name = "txtQueueNum";
            this.txtQueueNum.Size = new System.Drawing.Size(13, 13);
            this.txtQueueNum.TabIndex = 1;
            this.txtQueueNum.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "URL Queue:";
            // 
            // txtCopyRight
            // 
            this.txtCopyRight.AutoSize = true;
            this.txtCopyRight.Location = new System.Drawing.Point(452, 478);
            this.txtCopyRight.Name = "txtCopyRight";
            this.txtCopyRight.Size = new System.Drawing.Size(35, 13);
            this.txtCopyRight.TabIndex = 3;
            this.txtCopyRight.Text = "label8";
            // 
            // frmCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.txtCopyRight);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCrawler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crawler";
            this.Load += new System.EventHandler(this.frmCrawler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtQueueNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtStoredNum;
        private System.Windows.Forms.Label txtVisitedNum;
        private System.Windows.Forms.Label txtPosition;
        private System.Windows.Forms.Label txtSeedURL;
        private System.Windows.Forms.Label txtMaxpages;
        private System.Windows.Forms.Label txtPoliteness;
        private System.Windows.Forms.Label txtCurrentStorage;
        private System.Windows.Forms.Label txtCurrentURL;
        private System.Windows.Forms.Label txtMaxThreads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.Label txtCopyRight;
        private System.Windows.Forms.Button cmdArff;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Button cmdClassifier;

    }
}