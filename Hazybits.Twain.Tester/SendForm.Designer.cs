namespace Hazybits.Twain.Tester
{
    partial class SendForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Dest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_DG = new System.Windows.Forms.ComboBox();
            this.comboBox_DAT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_MSG = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Capability = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Container = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Returned = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultViewControl1 = new Hazybits.Twain.Tester.ResultViewControl();
            this.oneValueViewControl1 = new Hazybits.Twain.Tester.OneValueViewControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dest:";
            // 
            // comboBox_Dest
            // 
            this.comboBox_Dest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dest.FormattingEnabled = true;
            this.comboBox_Dest.Location = new System.Drawing.Point(75, 10);
            this.comboBox_Dest.Name = "comboBox_Dest";
            this.comboBox_Dest.Size = new System.Drawing.Size(198, 21);
            this.comboBox_Dest.TabIndex = 1;
            this.comboBox_Dest.SelectedIndexChanged += new System.EventHandler(this.OnDestChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DG:";
            // 
            // comboBox_DG
            // 
            this.comboBox_DG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DG.FormattingEnabled = true;
            this.comboBox_DG.Location = new System.Drawing.Point(75, 38);
            this.comboBox_DG.Name = "comboBox_DG";
            this.comboBox_DG.Size = new System.Drawing.Size(198, 21);
            this.comboBox_DG.TabIndex = 3;
            this.comboBox_DG.SelectedIndexChanged += new System.EventHandler(this.OnDgChanged);
            // 
            // comboBox_DAT
            // 
            this.comboBox_DAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DAT.FormattingEnabled = true;
            this.comboBox_DAT.Location = new System.Drawing.Point(75, 65);
            this.comboBox_DAT.Name = "comboBox_DAT";
            this.comboBox_DAT.Size = new System.Drawing.Size(198, 21);
            this.comboBox_DAT.TabIndex = 5;
            this.comboBox_DAT.SelectedIndexChanged += new System.EventHandler(this.OnDatChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DAT:";
            // 
            // comboBox_MSG
            // 
            this.comboBox_MSG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MSG.FormattingEnabled = true;
            this.comboBox_MSG.Location = new System.Drawing.Point(75, 92);
            this.comboBox_MSG.Name = "comboBox_MSG";
            this.comboBox_MSG.Size = new System.Drawing.Size(198, 21);
            this.comboBox_MSG.TabIndex = 7;
            this.comboBox_MSG.SelectedIndexChanged += new System.EventHandler(this.OnMsgChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MSG:";
            // 
            // comboBox_Capacity
            // 
            this.comboBox_Capability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Capability.FormattingEnabled = true;
            this.comboBox_Capability.Location = new System.Drawing.Point(75, 119);
            this.comboBox_Capability.Name = "comboBox_Capacity";
            this.comboBox_Capability.Size = new System.Drawing.Size(198, 21);
            this.comboBox_Capability.TabIndex = 9;
            this.comboBox_Capability.SelectedIndexChanged += new System.EventHandler(this.OnCapabilityChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capability:";
            // 
            // comboBox_Container
            // 
            this.comboBox_Container.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Container.FormattingEnabled = true;
            this.comboBox_Container.Location = new System.Drawing.Point(75, 146);
            this.comboBox_Container.Name = "comboBox_Container";
            this.comboBox_Container.Size = new System.Drawing.Size(198, 21);
            this.comboBox_Container.TabIndex = 11;
            this.comboBox_Container.SelectedIndexChanged += new System.EventHandler(this.OnContainerChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Container:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Returned";
            // 
            // textBox_Returned
            // 
            this.textBox_Returned.Location = new System.Drawing.Point(16, 209);
            this.textBox_Returned.Name = "textBox_Returned";
            this.textBox_Returned.ReadOnly = true;
            this.textBox_Returned.Size = new System.Drawing.Size(257, 20);
            this.textBox_Returned.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Structure:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(116, 405);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(197, 405);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultViewControl1
            // 
            this.resultViewControl1.Location = new System.Drawing.Point(11, 273);
            this.resultViewControl1.Name = "resultViewControl1";
            this.resultViewControl1.Size = new System.Drawing.Size(261, 126);
            this.resultViewControl1.TabIndex = 18;
            // 
            // oneValueViewControl1
            // 
            this.oneValueViewControl1.Location = new System.Drawing.Point(16, 274);
            this.oneValueViewControl1.Name = "oneValueViewControl1";
            this.oneValueViewControl1.Size = new System.Drawing.Size(256, 125);
            this.oneValueViewControl1.TabIndex = 19;
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 451);
            this.ControlBox = false;
            this.Controls.Add(this.oneValueViewControl1);
            this.Controls.Add(this.resultViewControl1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Returned);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Container);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Capability);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_MSG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_DAT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_DG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Dest);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Dest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_DG;
        private System.Windows.Forms.ComboBox comboBox_DAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_MSG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Capability;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Container;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Returned;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button closeButton;
        private ResultViewControl resultViewControl1;
        private OneValueViewControl oneValueViewControl1;
    }
}