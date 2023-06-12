using DTSCM.Verification;
using SqlDataBase;
using System;
using System.Windows.Forms;

namespace DTSCM.Settings
{
    public partial class PersonalSettingForm : Form
    {
        public PersonalSettingForm()
        {
            InitializeComponent();
        }

        private void PrsonalSettingForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            Posts.Items.AddRange(DataBase.Get.Posts().ToArray());
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (InitialsTextBox.Text == "" || Posts.SelectedItem == null || NewPassword.Text == "" || RepeatedPassword.Text == "")
            {
                MessageBox.Show("Все данные должны быть введены!");
                return;
            }
            if (InitialsTextBox.Text != StaffManager.CurrentStaff.Initials || Posts.SelectedItem.ToString() != StaffManager.CurrentStaff.Post)
            {
                MessageBox.Show("Вы неверно ввели свои личный данные");
                return;
            }
            if (NewPassword.Text != RepeatedPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            DataBase.Update.StaffPassword(StaffManager.CurrentStaff.StaffLogin, NewPassword.Text);
            MessageBox.Show("Пароль успешно обновлен");
            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e) => Hide();
    }
}
