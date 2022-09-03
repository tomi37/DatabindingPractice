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
            this.ComboGroupBox = new System.Windows.Forms.GroupBox();
            this.ExceptionGroupBox = new System.Windows.Forms.GroupBox();
            this.ErrorAsyncButton = new System.Windows.Forms.Button();
            this.ErrorButton = new System.Windows.Forms.Button();
            this.WarningButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MedicalCheckDataGridView = new System.Windows.Forms.DataGridView();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ENRadioButton = new DatabindingPractice.WinForm.Helpers.CustomRadioButton();
            this.JPRadioButton = new DatabindingPractice.WinForm.Helpers.CustomRadioButton();
            this.ComboGroupBox.SuspendLayout();
            this.ExceptionGroupBox.SuspendLayout();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalCheckDataGridView)).BeginInit();
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
            this.CheckButton.Location = new System.Drawing.Point(12, 315);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(106, 43);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            // 
            // ComboGroupBox
            // 
            this.ComboGroupBox.Controls.Add(this.UpdateButton);
            this.ComboGroupBox.Controls.Add(this.SettingComboBox);
            this.ComboGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ComboGroupBox.Name = "ComboGroupBox";
            this.ComboGroupBox.Size = new System.Drawing.Size(410, 90);
            this.ComboGroupBox.TabIndex = 3;
            this.ComboGroupBox.TabStop = false;
            this.ComboGroupBox.Text = "コンボボックス確認";
            // 
            // ExceptionGroupBox
            // 
            this.ExceptionGroupBox.Controls.Add(this.ErrorAsyncButton);
            this.ExceptionGroupBox.Controls.Add(this.ErrorButton);
            this.ExceptionGroupBox.Controls.Add(this.WarningButton);
            this.ExceptionGroupBox.Controls.Add(this.InfoButton);
            this.ExceptionGroupBox.Location = new System.Drawing.Point(12, 108);
            this.ExceptionGroupBox.Name = "ExceptionGroupBox";
            this.ExceptionGroupBox.Size = new System.Drawing.Size(410, 100);
            this.ExceptionGroupBox.TabIndex = 4;
            this.ExceptionGroupBox.TabStop = false;
            this.ExceptionGroupBox.Text = "例外確認";
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
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(172, 35);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(77, 40);
            this.ErrorButton.TabIndex = 7;
            this.ErrorButton.Text = "Error";
            this.ErrorButton.UseVisualStyleBackColor = true;
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
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(6, 35);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(77, 40);
            this.InfoButton.TabIndex = 5;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.ENRadioButton);
            this.LanguageGroupBox.Controls.Add(this.JPRadioButton);
            this.LanguageGroupBox.Location = new System.Drawing.Point(12, 225);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Size = new System.Drawing.Size(410, 66);
            this.LanguageGroupBox.TabIndex = 5;
            this.LanguageGroupBox.TabStop = false;
            this.LanguageGroupBox.Text = "言語選択確認";
            // 
            // MedicalCheckDataGridView
            // 
            this.MedicalCheckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalCheckDataGridView.Location = new System.Drawing.Point(412, 22);
            this.MedicalCheckDataGridView.Name = "MedicalCheckDataGridView";
            this.MedicalCheckDataGridView.RowHeadersWidth = 51;
            this.MedicalCheckDataGridView.RowTemplate.Height = 24;
            this.MedicalCheckDataGridView.Size = new System.Drawing.Size(493, 186);
            this.MedicalCheckDataGridView.TabIndex = 6;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Location = new System.Drawing.Point(412, 214);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(106, 43);
            this.GetDataButton.TabIndex = 7;
            this.GetDataButton.Text = "Get";
            this.GetDataButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(799, 214);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 43);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ENRadioButton
            // 
            this.ENRadioButton.AutoCheck = false;
            this.ENRadioButton.AutoSize = true;
            this.ENRadioButton.Location = new System.Drawing.Point(112, 31);
            this.ENRadioButton.Name = "ENRadioButton";
            this.ENRadioButton.Size = new System.Drawing.Size(72, 19);
            this.ENRadioButton.TabIndex = 7;
            this.ENRadioButton.TabStop = true;
            this.ENRadioButton.Text = "English";
            this.ENRadioButton.UseVisualStyleBackColor = true;
            // 
            // JPRadioButton
            // 
            this.JPRadioButton.AutoCheck = false;
            this.JPRadioButton.AutoSize = true;
            this.JPRadioButton.Location = new System.Drawing.Point(18, 31);
            this.JPRadioButton.Name = "JPRadioButton";
            this.JPRadioButton.Size = new System.Drawing.Size(88, 19);
            this.JPRadioButton.TabIndex = 6;
            this.JPRadioButton.TabStop = true;
            this.JPRadioButton.Text = "Japanese";
            this.JPRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.MedicalCheckDataGridView);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.ExceptionGroupBox);
            this.Controls.Add(this.ComboGroupBox);
            this.Controls.Add(this.CheckButton);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ComboGroupBox.ResumeLayout(false);
            this.ExceptionGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalCheckDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SettingComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.GroupBox ComboGroupBox;
        private System.Windows.Forms.GroupBox ExceptionGroupBox;
        private System.Windows.Forms.Button ErrorAsyncButton;
        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Button WarningButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Helpers.CustomRadioButton ENRadioButton;
        private Helpers.CustomRadioButton JPRadioButton;
        private System.Windows.Forms.DataGridView MedicalCheckDataGridView;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button ClearButton;
    }
}