namespace DTSCM.Settings
{
    partial class ChangeStaffForm
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
            this.SaveChanges = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AddRole = new System.Windows.Forms.Button();
            this.StaffLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccessLevels = new System.Windows.Forms.ComboBox();
            this.Posts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Initials = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(57, 344);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(193, 37);
            this.SaveChanges.TabIndex = 13;
            this.SaveChanges.Text = "Изменить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(266, 344);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 37);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddRole
            // 
            this.AddRole.Location = new System.Drawing.Point(56, 344);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(193, 37);
            this.AddRole.TabIndex = 11;
            this.AddRole.Text = "Добавить";
            this.AddRole.UseVisualStyleBackColor = true;
            this.AddRole.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // StaffLogin
            // 
            this.StaffLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffLogin.Location = new System.Drawing.Point(57, 67);
            this.StaffLogin.Name = "StaffLogin";
            this.StaffLogin.Size = new System.Drawing.Size(344, 22);
            this.StaffLogin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Уровень доступа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин сотрудника";
            // 
            // AccessLevels
            // 
            this.AccessLevels.FormattingEnabled = true;
            this.AccessLevels.Location = new System.Drawing.Point(56, 242);
            this.AccessLevels.Name = "AccessLevels";
            this.AccessLevels.Size = new System.Drawing.Size(345, 21);
            this.AccessLevels.TabIndex = 14;
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.Location = new System.Drawing.Point(56, 295);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(345, 21);
            this.Posts.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Должность:";
            // 
            // Initials
            // 
            this.Initials.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Initials.Location = new System.Drawing.Point(56, 127);
            this.Initials.Name = "Initials";
            this.Initials.Size = new System.Drawing.Size(344, 22);
            this.Initials.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(53, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "ФИО сотрудника";
            // 
            // StaffPassword
            // 
            this.StaffPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffPassword.Location = new System.Drawing.Point(56, 181);
            this.StaffPassword.Name = "StaffPassword";
            this.StaffPassword.Size = new System.Drawing.Size(344, 22);
            this.StaffPassword.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(53, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Пароль:";
            // 
            // ChangeStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 428);
            this.Controls.Add(this.StaffPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Initials);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Posts);
            this.Controls.Add(this.AccessLevels);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.StaffLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeStaffForm";
            this.Text = "ChangeStaffForm";
            this.Load += new System.EventHandler(this.ChangeStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AddRole;
        public System.Windows.Forms.TextBox StaffLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox AccessLevels;
        public System.Windows.Forms.ComboBox Posts;
        public System.Windows.Forms.TextBox Initials;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox StaffPassword;
        private System.Windows.Forms.Label label5;
    }
}