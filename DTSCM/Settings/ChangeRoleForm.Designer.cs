namespace DTSCM.Settings
{
    partial class ChangeRoleForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Comments = new System.Windows.Forms.RichTextBox();
            this.AddRole = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наиментования уровня доступа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Комментарии:";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(26, 46);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(344, 22);
            this.Title.TabIndex = 2;
            // 
            // Comments
            // 
            this.Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comments.Location = new System.Drawing.Point(26, 97);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(344, 96);
            this.Comments.TabIndex = 3;
            this.Comments.Text = "";
            // 
            // AddRole
            // 
            this.AddRole.Location = new System.Drawing.Point(26, 208);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(193, 37);
            this.AddRole.TabIndex = 4;
            this.AddRole.Text = "Добавить";
            this.AddRole.UseVisualStyleBackColor = true;
            this.AddRole.Click += new System.EventHandler(this.AddRole_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(236, 208);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 37);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Закрыть окно";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(26, 208);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(193, 37);
            this.SaveChanges.TabIndex = 6;
            this.SaveChanges.Text = "Изменить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ChangeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 274);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeRoleForm";
            this.Text = "ChangeRoleForm";
            this.Load += new System.EventHandler(this.ChangeRoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddRole;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveChanges;
        public System.Windows.Forms.TextBox Title;
        public System.Windows.Forms.RichTextBox Comments;
    }
}