namespace DTSCM.Director
{
    partial class DirectorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SettingsSubMenu = new System.Windows.Forms.Panel();
            this.StaffList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PersonalSettings = new System.Windows.Forms.Button();
            this.FireDetectorSettings = new System.Windows.Forms.Button();
            this.AccessLevelSettings = new System.Windows.Forms.Button();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SettingsSubMenu.SuspendLayout();
            this.ChildFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.StaffList);
            this.panel1.Controls.Add(this.SettingsSubMenu);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 481);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 86);
            this.panel2.TabIndex = 6;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.Location = new System.Drawing.Point(0, 86);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(218, 35);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SettingsSubMenu
            // 
            this.SettingsSubMenu.Controls.Add(this.AccessLevelSettings);
            this.SettingsSubMenu.Controls.Add(this.FireDetectorSettings);
            this.SettingsSubMenu.Controls.Add(this.PersonalSettings);
            this.SettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsSubMenu.Location = new System.Drawing.Point(0, 121);
            this.SettingsSubMenu.Name = "SettingsSubMenu";
            this.SettingsSubMenu.Size = new System.Drawing.Size(218, 70);
            this.SettingsSubMenu.TabIndex = 6;
            // 
            // StaffList
            // 
            this.StaffList.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaffList.Location = new System.Drawing.Point(0, 191);
            this.StaffList.Name = "StaffList";
            this.StaffList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StaffList.Size = new System.Drawing.Size(218, 35);
            this.StaffList.TabIndex = 7;
            this.StaffList.Text = "Список пользователей";
            this.StaffList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffList.UseVisualStyleBackColor = true;
            this.StaffList.Click += new System.EventHandler(this.StaffList_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 77);
            this.panel4.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.Location = new System.Drawing.Point(0, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(218, 35);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Выход ";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PersonalSettings
            // 
            this.PersonalSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonalSettings.Location = new System.Drawing.Point(0, 0);
            this.PersonalSettings.Name = "PersonalSettings";
            this.PersonalSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.PersonalSettings.Size = new System.Drawing.Size(218, 23);
            this.PersonalSettings.TabIndex = 0;
            this.PersonalSettings.Text = "Персональные настройки";
            this.PersonalSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonalSettings.UseVisualStyleBackColor = true;
            this.PersonalSettings.Click += new System.EventHandler(this.PersonalSettings_Click);
            // 
            // FireDetectorSettings
            // 
            this.FireDetectorSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.FireDetectorSettings.Location = new System.Drawing.Point(0, 23);
            this.FireDetectorSettings.Name = "FireDetectorSettings";
            this.FireDetectorSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.FireDetectorSettings.Size = new System.Drawing.Size(218, 23);
            this.FireDetectorSettings.TabIndex = 1;
            this.FireDetectorSettings.Text = "Настройки объектов и извещателей";
            this.FireDetectorSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FireDetectorSettings.UseVisualStyleBackColor = true;
            this.FireDetectorSettings.Click += new System.EventHandler(this.FireDetectorSettings_Click);
            // 
            // AccessLevelSettings
            // 
            this.AccessLevelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccessLevelSettings.Location = new System.Drawing.Point(0, 46);
            this.AccessLevelSettings.Name = "AccessLevelSettings";
            this.AccessLevelSettings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.AccessLevelSettings.Size = new System.Drawing.Size(218, 23);
            this.AccessLevelSettings.TabIndex = 2;
            this.AccessLevelSettings.Text = "Настройки уровней доступа";
            this.AccessLevelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccessLevelSettings.UseVisualStyleBackColor = true;
            this.AccessLevelSettings.Click += new System.EventHandler(this.AccessLevelSettings_Click);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Controls.Add(this.label1);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(220, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(667, 481);
            this.ChildFormPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сюда будет открываться соответствующая форма";
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 481);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.panel1.ResumeLayout(false);
            this.SettingsSubMenu.ResumeLayout(false);
            this.ChildFormPanel.ResumeLayout(false);
            this.ChildFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel SettingsSubMenu;
        private System.Windows.Forms.Button StaffList;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AccessLevelSettings;
        private System.Windows.Forms.Button FireDetectorSettings;
        private System.Windows.Forms.Button PersonalSettings;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Label label1;
    }
}