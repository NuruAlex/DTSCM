using DTSCM.Administrator;
using SqlDataBase;
using SqlDataBase.Tables;
using System;
using System.Windows.Forms;

namespace DTSCM.Settings
{
    public partial class ChangeStaffForm : Form
    {
        public bool Added = false;
        public bool Refuced = false;
        public ChangeStaffForm()
        {
            InitializeComponent();
            StaffLogin.Enabled = true;
            StaffPassword.Enabled = true;
            Initials.Enabled = true;
            AccessLevels.Enabled = true;
            Posts.Enabled = true;
            AddRole.Visible = true;
            SaveChanges.Visible = false;
        }
        public ChangeStaffForm(string staffLogin)
        {
            InitializeComponent();
            LoadStaff(staffLogin);
            StaffLogin.Enabled = false;
            StaffPassword.Enabled = false;
            Initials.Enabled = false;
            AccessLevels.Enabled = true;
            Posts.Enabled = false;
            AddRole.Visible = false;
            SaveChanges.Visible = true;
        }
        private void LoadStaff(string staffLogin)
        {
            SqlDataBase.Tables.Staffs.Director staff = (SqlDataBase.Tables.Staffs.Director)DataBase.Get.StaffByLogin<SqlDataBase.Tables.Staffs.Director>(staffLogin);

            if (staff != null)
            {
                StaffLogin.Text = staffLogin;
                StaffPassword.Text = staff.StaffPassword;
                Initials.Text = staff.Initials;
                AccessLevels.Text = staff.AccessLevel;
                Posts.Text = staff.Post;
                return;
            }
            SqlDataBase.Tables.Staffs.Director changedStaff = (SqlDataBase.Tables.Staffs.Director)StaffListForm.updatedStaffs.Find(i => i.StaffLogin == staffLogin);
            if (changedStaff != null)
            {
                StaffLogin.Text = staffLogin;
                StaffPassword.Text = changedStaff.StaffPassword;
                Initials.Text = changedStaff.Initials;
                AccessLevels.Text = changedStaff.AccessLevel;
                Posts.Text = changedStaff.Post;
                return;
            }
            SqlDataBase.Tables.Staffs.Director addedStaff = (SqlDataBase.Tables.Staffs.Director)StaffListForm.addedStaffs.Find(i => i.StaffLogin == staffLogin);
            StaffLogin.Text = staffLogin;
            StaffPassword.Text = addedStaff.StaffPassword;
            Initials.Text = addedStaff.Initials;
            AccessLevels.Text = addedStaff.AccessLevel;
            Posts.Text = addedStaff.Post;
        }
        private void ChangeStaffForm_Load(object sender, EventArgs e)
        {
            Posts.Items.AddRange(DataBase.Get.Posts().ToArray());
            foreach (AccessRole role in DataBase.Get.Roles())
                AccessLevels.Items.Add(role.Title);
            FormClosed += (s, ev) => Hide();
            Icon = Properties.Resources.Icon;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < StaffListForm.updatedStaffs.Count; i++)
                if (StaffLogin.Text == StaffListForm.updatedStaffs[i].StaffLogin)
                    StaffListForm.updatedStaffs[i].AccessLevel = AccessLevels.SelectedItem.ToString();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Refuced = true;
            Hide();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            if (StaffLogin.Text == "" || Initials.Text == "" || StaffPassword.Text == "" || AccessLevels.SelectedItem == null || Posts.SelectedItem == null)
            {
                MessageBox.Show("Все данные нужно ввести");
                return;
            }
            if (DataBase.Get.StaffByLogin<SqlDataBase.Tables.Staffs.Director>(StaffLogin.Text) != null)
            {
                MessageBox.Show("Такой персонал уже существует");
                return;
            }
            StaffListForm.addedStaffs.Add(new SqlDataBase.Tables.Staffs.Director
            {
                StaffLogin = StaffLogin.Text,
                Initials = Initials.Text,
                StaffPassword = StaffPassword.Text,
                Post = Posts.SelectedItem.ToString(),
                AccessLevel =AccessLevels.SelectedItem.ToString()
            }) ;
            Added = true;
            Hide();
        }
    }
}
