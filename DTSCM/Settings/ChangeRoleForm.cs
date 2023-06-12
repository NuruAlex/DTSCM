using SqlDataBase;
using SqlDataBase.Tables;
using System;
using System.Windows.Forms;

namespace DTSCM.Settings
{
    public partial class ChangeRoleForm : Form
    {
        public ChangeRoleForm()
        {
            InitializeComponent();
            Title.ReadOnly = false;
            AddRole.Visible = true;
            SaveChanges.Visible = false;
        }
        public bool Added = false;
        public ChangeRoleForm(string roleTitle)
        {
            InitializeComponent();
            Title.Text = roleTitle;
            Title.ReadOnly = true;
            LoadRole(roleTitle);

            AddRole.Visible = false;
            SaveChanges.Visible = true;
        }
        private void LoadRole(string roleTitle)
        {
            AccessRole updatedRole = AccessLevelForm.changedRoles.Find(i => i.Title == roleTitle);
            if (updatedRole != null)
            {
                Title.Text = updatedRole.Title;
                Comments.Text = updatedRole.Comments;
                return;
            }

            AccessRole role = DataBase.Get.AccessRoleByTitle(roleTitle);
            if (role != null)
            {
                Comments.Text = role.Comments;
                return;
            }

            AccessRole addedrole = AccessLevelForm.addedRoles.Find(i => i.Title == roleTitle);
            Title.Text = addedrole.Title;
            Comments.Text = addedrole.Comments;

        }
        private void AddRole_Click(object sender, EventArgs e)
        {
            if (Title.Text == "")
            {
                MessageBox.Show("Введите наименование роли доступа");
                return;
            }
            if(DataBase.Get.AccessRoleByTitle(Title.Text) != null)
            {
                MessageBox.Show("Уровень доступа с таким наименованием уже существует");
                return;
            }
            AccessLevelForm.addedRoles.Add(new AccessRole { Title = Title.Text, Comments = Comments.Text });
            Added = true;
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AccessLevelForm.changedRoles.Count; i++)
                if (Title.Text == AccessLevelForm.changedRoles[i].Title)
                    AccessLevelForm.changedRoles[i].Comments = Comments.Text;
            Hide();
        }

        private void ChangeRoleForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            Icon = Properties.Resources.Icon;
        }
    }
}
