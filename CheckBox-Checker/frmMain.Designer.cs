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
            this.SuspendLayout();
            // 
            // mainBrowserControl
            // 
            this.mainBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBrowserControl.Location = new System.Drawing.Point(0, 0);
            this.mainBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainBrowserControl.Name = "mainBrowserControl";
            this.mainBrowserControl.Size = new System.Drawing.Size(921, 490);
            this.mainBrowserControl.TabIndex = 0;
            this.mainBrowserControl.Url = new System.Uri("http://adsict.ethdigitalcampus.com/DCWeb/", System.UriKind.Absolute);
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
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(505, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 490);
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
    }
}

