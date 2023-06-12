using DTSCM.Settings;
using SqlDataBase;
using SqlDataBase.Tables.Staffs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DTSCM.Administrator
{
    public partial class StaffListForm : Form
    {
        public StaffListForm() => InitializeComponent();

        public static List<IStaff> deletedStaffs = new List<IStaff>();
        public static List<IStaff> addedStaffs = new List<IStaff>();
        public static List<IStaff> updatedStaffs = new List<IStaff>();
       
        private void StaffListForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Hide();
            List<SqlDataBase.Tables.Staffs.Director> staffs = DataBase.Get.Staffs();

            foreach (SqlDataBase.Tables.Staffs.Director staff in staffs)
            {
                int index = StaffTable.Rows.Add();
                StaffTable.Rows[index].Cells[0].Value = staff.StaffLogin;
                StaffTable.Rows[index].Cells[1].Value = staff.AccessLevel;
                StaffTable.Rows[index].Cells[2].Value = staff.LastDateEntered.ToString("G");
            }
        }

        private void ClearChanges()
        {
            deletedStaffs.Clear();
            addedStaffs.Clear();
            updatedStaffs.Clear();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ClearChanges();
            Hide();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            ChangeStaffForm form = new ChangeStaffForm();
            form.ShowDialog();
            while (!form.Refuced)
            {
                if (form.Added)
                {
                    int index = StaffTable.Rows.Add();
                    StaffTable.Rows[index].Cells[0].Value = form.StaffLogin.Text;
                    StaffTable.Rows[index].Cells[1].Value = form.AccessLevels.Text;
                    StaffTable.Rows[index].Cells[2].Value = "Не заходил в систему";
                    form.Added = false;
                    break;
                }
            }
        }

        private void ChangeStaffButton_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count == 1)
                new ChangeStaffForm(StaffTable.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
        }

        private void DeleteStaffButton_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одного пользователя");
                return;
            }
            deletedStaffs.Add(new SqlDataBase.Tables.Staffs.Director
            {
                StaffLogin = StaffTable.SelectedRows[0].Cells[0].Value.ToString(),
                AccessLevel = StaffTable.SelectedRows[0].Cells[1].Value.ToString(),
            });
            StaffTable.Rows.RemoveAt(StaffTable.SelectedRows[0].Index);
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите внести все изменения?", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            foreach (SqlDataBase.Tables.Staffs.Director staff in addedStaffs)
                DataBase.Add.Staff(staff);
            foreach (SqlDataBase.Tables.Staffs.Director staff in updatedStaffs)
                DataBase.Update.Staff(staff);
            foreach (SqlDataBase.Tables.Staffs.Director staff in deletedStaffs)
                DataBase.Delete.Staff(staff);

            ClearChanges();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearChanges();
            Hide();
        }
    }
}
