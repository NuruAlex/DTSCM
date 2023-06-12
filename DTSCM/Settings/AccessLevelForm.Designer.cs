namespace DTSCM.Settings
{
    partial class AccessLevelForm
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
            this.RolesTable = new System.Windows.Forms.DataGridView();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.ChangeRoleButton = new System.Windows.Forms.Button();
            this.DeleteRoleButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RolesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список ролей:";
            // 
            // RolesTable
            // 
            this.RolesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title});
            this.RolesTable.Location = new System.Drawing.Point(12, 38);
            this.RolesTable.Name = "RolesTable";
            this.RolesTable.Size = new System.Drawing.Size(603, 246);
            this.RolesTable.TabIndex = 1;
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.Location = new System.Drawing.Point(15, 324);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(177, 34);
            this.AddRoleButton.TabIndex = 2;
            this.AddRoleButton.Text = "Добавить новую роль";
            this.AddRoleButton.UseVisualStyleBackColor = true;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(198, 324);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(211, 34);
            this.ChangeRoleButton.TabIndex = 3;
            this.ChangeRoleButton.Text = "Изменить роль";
            this.ChangeRoleButton.UseVisualStyleBackColor = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // DeleteRoleButton
            // 
            this.DeleteRoleButton.Location = new System.Drawing.Point(415, 324);
            this.DeleteRoleButton.Name = "DeleteRoleButton";
            this.DeleteRoleButton.Size = new System.Drawing.Size(205, 34);
            this.DeleteRoleButton.TabIndex = 4;
            this.DeleteRoleButton.Text = "Удалить роль";
            this.DeleteRoleButton.UseVisualStyleBackColor = true;
            this.DeleteRoleButton.Click += new System.EventHandler(this.DeleteRoleButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(15, 364);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(294, 51);
            this.SaveChangesButton.TabIndex = 5;
            this.SaveChangesButton.Text = "Сохранить изменения";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(336, 364);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(284, 51);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование уровня доступа";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // AccessLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 438);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.DeleteRoleButton);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.AddRoleButton);
            this.Controls.Add(this.RolesTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccessLevelForm";
            this.Text = "AccessLevelForm";
            this.Load += new System.EventHandler(this.AccessLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button ChangeRoleButton;
        private System.Windows.Forms.Button DeleteRoleButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        public System.Windows.Forms.DataGridView RolesTable;
    }
}