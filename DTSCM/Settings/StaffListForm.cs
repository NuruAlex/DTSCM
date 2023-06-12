using SqlDataBase;
using SqlDataBase.Tables.Staffs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DTSCM.Administrator
{
    public partial class StaffListForm : Form
    {
        public StaffListForm()
        {
            InitializeComponent();
        }
        private List<IStaff> deletedStaffs = new List<IStaff>();
        private List<IStaff> addedStaffs = new List<IStaff>();
        private List<IStaff> updatedStaffs = new List<IStaff>();
        private void StaffListForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            List<SqlDataBase.Tables.Staffs.Director> staffs = DataBase.Get.Staffs();
            
            foreach(SqlDataBase.Tables.Staffs.Director staff in staffs)
            {
                int index = StaffTable.Rows.Add();
                StaffTable.Rows[index].Cells[0].Value = staff.StaffLogin;
                StaffTable.Rows[index].Cells[1].Value = staff.AccessLevel;
                StaffTable.Rows[index].Cells[2].Value = staff.LastDateEntered.ToString("G");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeStaffButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStaffButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
