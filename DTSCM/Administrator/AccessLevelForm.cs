using System;
using System.Windows.Forms;

namespace DTSCM.Administrator
{
    public partial class AccessLevelForm : Form
    {
        public AccessLevelForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AccessLevelForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
        }
    }
}
