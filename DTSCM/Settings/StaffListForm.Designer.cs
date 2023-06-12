namespace DTSCM.Administrator
{
    partial class StaffListForm
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
            this.StaffTable = new System.Windows.Forms.DataGridView();
            this.AddStaffButton = new System.Windows.Forms.Button();
            this.ChangeStaffButton = new System.Windows.Forms.Button();
            this.DeleteStaffButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDateEntered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffTable
            // 
            this.StaffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffLogin,
            this.AccessLevel,
            this.LastDateEntered});
            this.StaffTable.Location = new System.Drawing.Point(12, 58);
            this.StaffTable.Name = "StaffTable";
            this.StaffTable.Size = new System.Drawing.Size(616, 258);
            this.StaffTable.TabIndex = 0;
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.Location = new System.Drawing.Point(12, 357);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Size = new System.Drawing.Size(173, 34);
            this.AddStaffButton.TabIndex = 2;
            this.AddStaffButton.Text = "Добавить пользователя";
            this.AddStaffButton.UseVisualStyleBackColor = true;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // ChangeStaffButton
            // 
            this.ChangeStaffButton.Location = new System.Drawing.Point(191, 357);
            this.ChangeStaffButton.Name = "ChangeStaffButton";
            this.ChangeStaffButton.Size = new System.Drawing.Size(196, 34);
            this.ChangeStaffButton.TabIndex = 3;
            this.ChangeStaffButton.Text = "Изменить";
            this.ChangeStaffButton.UseVisualStyleBackColor = true;
            this.ChangeStaffButton.Click += new System.EventHandler(this.ChangeStaffButton_Click);
            // 
            // DeleteStaffButton
            // 
            this.DeleteStaffButton.Location = new System.Drawing.Point(393, 357);
            this.DeleteStaffButton.Name = "DeleteStaffButton";
            this.DeleteStaffButton.Size = new System.Drawing.Size(235, 34);
            this.DeleteStaffButton.TabIndex = 4;
            this.DeleteStaffButton.Text = "Удалить";
            this.DeleteStaffButton.UseVisualStyleBackColor = true;
            this.DeleteStaffButton.Click += new System.EventHandler(this.DeleteStaffButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 404);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(345, 51);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(363, 404);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(265, 51);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список пользователей:";
            // 
            // StaffLogin
            // 
            this.StaffLogin.HeaderText = "Логин";
            this.StaffLogin.Name = "StaffLogin";
            // 
            // AccessLevel
            // 
            this.AccessLevel.HeaderText = "Уровень доступа";
            this.AccessLevel.Name = "AccessLevel";
            this.AccessLevel.ReadOnly = true;
            this.AccessLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AccessLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastDateEntered
            // 
            this.LastDateEntered.HeaderText = "Последний вход";
            this.LastDateEntered.Name = "LastDateEntered";
            this.LastDateEntered.ReadOnly = true;
            // 
            // StaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.DeleteStaffButton);
            this.Controls.Add(this.ChangeStaffButton);
            this.Controls.Add(this.AddStaffButton);
            this.Controls.Add(this.StaffTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffListForm";
            this.Text = "StaffListForm";
            this.Load += new System.EventHandler(this.StaffListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffTable;
        private System.Windows.Forms.Button AddStaffButton;
        private System.Windows.Forms.Button ChangeStaffButton;
        private System.Windows.Forms.Button DeleteStaffButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDateEntered;
    }
}