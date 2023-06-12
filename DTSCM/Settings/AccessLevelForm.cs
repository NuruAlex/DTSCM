using SqlDataBase;
using SqlDataBase.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DTSCM.Settings
{
    public partial class AccessLevelForm : Form
    {
        public AccessLevelForm() => InitializeComponent();

        public static List<AccessRole> deletedRoles = new List<AccessRole>();
        public static List<AccessRole> changedRoles = new List<AccessRole>();
        public static List<AccessRole> addedRoles = new List<AccessRole>();
      
        private void AccessLevelForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) =>
            {
                ClearALlChanges();
                Hide();
            };
            foreach (AccessRole role in DataBase.Get.Roles())
            {
                int index = RolesTable.Rows.Add();
                RolesTable.Rows[index].Cells[0].Value = role.Title;
            }
        }

        private void AddRoleButton_Click(object sender, EventArgs e)
        {
            ChangeRoleForm form = new ChangeRoleForm();
            form.ShowDialog();
            while (true)
            {
                if (form.Added)
                {
                    int index = RolesTable.Rows.Add();
                    RolesTable.Rows[index].Cells[0].Value = form.Title.Text;
                    form.Added = false;
                    break;
                }
            }
        }
        private void ClearALlChanges()
        {
            deletedRoles.Clear();
            changedRoles.Clear();
            addedRoles.Clear();
        }
        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (RolesTable.SelectedRows.Count == 1)
                new ChangeRoleForm(RolesTable.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
        }

        private void DeleteRoleButton_Click(object sender, EventArgs e)
        {
            if (RolesTable.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну роль!");
                return;
            }
            deletedRoles.Add(new AccessRole { Title = RolesTable.SelectedRows[0].Cells[0].Value.ToString() });
            RolesTable.Rows.RemoveAt(RolesTable.SelectedRows[0].Index);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите внести все изменения?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            foreach (AccessRole role in addedRoles)
                DataBase.Add.Role(role);
            foreach (AccessRole role in changedRoles)
                DataBase.Update.Role(role);
            foreach (AccessRole role in deletedRoles)
                DataBase.Delete.Role(role);
            ClearALlChanges();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearALlChanges();
            Hide();
        }
    }
}
