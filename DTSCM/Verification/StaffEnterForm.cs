using System;
using System.Windows.Forms;

namespace DTSCM.Verification
{
    public partial class StaffEnterForm : Form
    {
        public StaffEnterForm() => InitializeComponent();

        public bool passed = false;
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || password.Text == "")
            {
                MessageBox.Show("Все данные должны быть введены");
                new ChosingActionForm().Show();
                Hide();
                return;
            }
            if (!StaffManager.StaffIsExist(login.Text, password.Text))
            {
                MessageBox.Show("Такого персонала не существует");
                new ChosingActionForm().Show();
                Hide();
                return;
            }
            StaffManager.Enter();
            Hide();
        }

        private void StaffEnterForm_Load(object sender, EventArgs e) => FormClosed += (s, ev) => Application.Exit();

        private void ExitButton_Click(object sender, EventArgs e)
        {
            new ChosingActionForm().Show();
            Hide();
        }
    }
}
