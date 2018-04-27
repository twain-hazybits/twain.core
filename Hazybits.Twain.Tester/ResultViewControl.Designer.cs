namespace Hazybits.Twain.Tester
{
    partial class ResultViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Structure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Structure
            // 
            this.textBox_Structure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Structure.Location = new System.Drawing.Point(0, 0);
            this.textBox_Structure.Multiline = true;
            this.textBox_Structure.Name = "textBox_Structure";
            this.textBox_Structure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Structure.Size = new System.Drawing.Size(305, 203);
            this.textBox_Structure.TabIndex = 16;
            // 
            // ResultViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Structure);
            this.Name = "ResultViewControl";
            this.Size = new System.Drawing.Size(305, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Structure;
    }
}
