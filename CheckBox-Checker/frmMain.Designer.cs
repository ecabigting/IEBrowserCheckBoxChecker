namespace CheckBox_Checker
{
    partial class frmMain
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
            this.mainBrowserControl = new System.Windows.Forms.WebBrowser();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.cmbSelectGrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mainBrowserControl
            // 
            this.mainBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBrowserControl.Location = new System.Drawing.Point(0, 0);
            this.mainBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainBrowserControl.Name = "mainBrowserControl";
            this.mainBrowserControl.Size = new System.Drawing.Size(1089, 490);
            this.mainBrowserControl.TabIndex = 0;
            this.mainBrowserControl.Url = new System.Uri("", System.UriKind.Relative);
            this.mainBrowserControl.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainBrowserControl_DocumentCompleted);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(414, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "OpenFile(txt)";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.UseWaitCursor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(12, 3);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(396, 20);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.UseWaitCursor = true;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(704, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.UseWaitCursor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cmbSelectGrade
            // 
            this.cmbSelectGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectGrade.FormattingEnabled = true;
            this.cmbSelectGrade.Location = new System.Drawing.Point(541, 5);
            this.cmbSelectGrade.Name = "cmbSelectGrade";
            this.cmbSelectGrade.Size = new System.Drawing.Size(50, 21);
            this.cmbSelectGrade.TabIndex = 4;
            this.cmbSelectGrade.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grade:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class:";
            this.label2.UseWaitCursor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(638, 5);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(50, 21);
            this.cmbClass.TabIndex = 7;
            this.cmbClass.UseWaitCursor = true;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 490);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectGrade);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.mainBrowserControl);
            this.Name = "frmMain";
            this.Text = "CheckTheCheckBoxes";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainBrowserControl;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmbSelectGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
    }
}

