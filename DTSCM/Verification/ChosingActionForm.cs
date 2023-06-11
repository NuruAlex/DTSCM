using System;
using System.Windows.Forms;

namespace DTSCM.Verification
{
    public partial class ChosingActionForm : Form
    {
        public ChosingActionForm() => InitializeComponent();

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            new StaffEnterForm().Show();
            Hide();
        }
        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void ChosingActionForm_Load(object sender, EventArgs e) => FormClosed += (s, ev) => Application.Exit();
    }
}
