namespace Hazybits.Twain.Tester
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dSMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // dSMToolStripMenuItem
            // 
            this.dSMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDSMToolStripMenuItem,
            this.openDSToolStripMenuItem,
            this.sendToolStripMenuItem,
            this.closeDSToolStripMenuItem,
            this.closeDSMToolStripMenuItem});
            this.dSMToolStripMenuItem.Name = "dSMToolStripMenuItem";
            this.dSMToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dSMToolStripMenuItem.Text = "Special";
            // 
            // openDSMToolStripMenuItem
            // 
            this.openDSMToolStripMenuItem.Name = "openDSMToolStripMenuItem";
            this.openDSMToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openDSMToolStripMenuItem.Text = "Load/Open DSM";
            this.openDSMToolStripMenuItem.Click += new System.EventHandler(this.openDSMToolStripMenuItem_Click);
            // 
            // openDSToolStripMenuItem
            // 
            this.openDSToolStripMenuItem.Name = "openDSToolStripMenuItem";
            this.openDSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openDSToolStripMenuItem.Text = "Open Source";
            this.openDSToolStripMenuItem.Click += new System.EventHandler(this.openDSToolStripMenuItem_Click);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sendToolStripMenuItem.Text = "Send...";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // closeDSToolStripMenuItem
            // 
            this.closeDSToolStripMenuItem.Name = "closeDSToolStripMenuItem";
            this.closeDSToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeDSToolStripMenuItem.Text = "Close Source";
            this.closeDSToolStripMenuItem.Click += new System.EventHandler(this.closeDSToolStripMenuItem_Click);
            // 
            // closeDSMToolStripMenuItem
            // 
            this.closeDSMToolStripMenuItem.Name = "closeDSMToolStripMenuItem";
            this.closeDSMToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeDSMToolStripMenuItem.Text = "Unload/Close DSM";
            this.closeDSMToolStripMenuItem.Click += new System.EventHandler(this.closeDSMToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 383);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
    }
}

