using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTSCM.Security
{
    public partial class SecurityForm : Form
    {
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void SecurityForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Application.Exit();
            Icon = Properties.Resources.Icon;
        }

    }
}
