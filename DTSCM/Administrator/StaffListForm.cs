using SqlDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTSCM.Administrator
{
    public partial class StaffListForm : Form
    {
        public StaffListForm()
        {
            InitializeComponent();
        }

        private void StaffListForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            StaffTable.DataSource = DataBase.Get.Staffs();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
