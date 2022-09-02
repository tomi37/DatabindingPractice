namespace DatabindingPractice.WinForm.Views
{
    partial class MainView
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
            this.SettingComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InfoButton = new System.Windows.Forms.Button();
            this.WarningButton = new System.Windows.Forms.Button();
            this.ErrorButton = new System.Windows.Forms.Button();
            this.ErrorAsyncButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingComboBox
            // 
            this.SettingComboBox.FormattingEnabled = true;
            this.SettingComboBox.Location = new System.Drawing.Point(118, 30);
            this.SettingComboBox.Name = "SettingComboBox";
            this.SettingComboBox.Size = new System.Drawing.Size(121, 23);
            this.SettingComboBox.TabIndex = 0;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(6, 30);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(106, 43);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(682, 12);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(106, 43);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.SettingComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コンボボックス確認";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ErrorAsyncButton);
            this.groupBox2.Controls.Add(this.ErrorButton);
            this.groupBox2.Controls.Add(this.WarningButton);
            this.groupBox2.Controls.Add(this.InfoButton);
            this.groupBox2.Location = new System.Drawing.Point(18, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "例外確認";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(6, 35);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(77, 40);
            this.InfoButton.TabIndex = 5;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // WarningButton
            // 
            this.WarningButton.Location = new System.Drawing.Point(89, 35);
            this.WarningButton.Name = "WarningButton";
            this.WarningButton.Size = new System.Drawing.Size(77, 40);
            this.WarningButton.TabIndex = 6;
            this.WarningButton.Text = "Warning";
            this.WarningButton.UseVisualStyleBackColor = true;
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(172, 35);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(77, 40);
            this.ErrorButton.TabIndex = 7;
            this.ErrorButton.Text = "Error";
            this.ErrorButton.UseVisualStyleBackColor = true;
            // 
            // ErrorAsyncButton
            // 
            this.ErrorAsyncButton.Location = new System.Drawing.Point(255, 35);
            this.ErrorAsyncButton.Name = "ErrorAsyncButton";
            this.ErrorAsyncButton.Size = new System.Drawing.Size(110, 40);
            this.ErrorAsyncButton.TabIndex = 8;
            this.ErrorAsyncButton.Text = "ErrorAsync";
            this.ErrorAsyncButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckButton);
            this.Name = "MainView";
            this.Text = "MainView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SettingComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ErrorAsyncButton;
        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Button WarningButton;
        private System.Windows.Forms.Button InfoButton;
    }
}