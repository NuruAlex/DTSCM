using System;
using SqlDataBase;
using System.Windows.Forms;

namespace DTSCM.Verification
{
    public partial class StaffEnterForm : Form
    {
        public StaffEnterForm() => InitializeComponent();


        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(Password.Text == "" || Posts.SelectedItem == null)
            {
                MessageBox.Show("Все данные должны быть введены");
                return;
            }
            if(!StaffManager.StaffIsExist(Posts.Text,Password.Text))
            {
                MessageBox.Show("Такого персонала не существует");
                return;
            }
            StaffManager.Enter();
        }

        private void StaffEnterForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Application.Exit();
            Posts.Items.AddRange(DataBase.Get.Posts().ToArray());
        }
    }
}
