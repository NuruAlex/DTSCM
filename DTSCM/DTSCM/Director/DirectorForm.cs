using System;
using System.Windows.Forms;

namespace DTSCM.Director
{
    public partial class DirectorForm : Form
    {
        private Form _currentChildForm = null;
        public DirectorForm() => InitializeComponent();
        private void DirectorForm_Load(object sender, EventArgs e)
        {
            FormClosed += (s, ev) => Application.Exit();
            SettingsSubMenu.Visible = false;
        }

        private void SettingsButton_Click(object sender, EventArgs e) => SettingsSubMenu.Visible = true;

        private void HideSubMenu() => SettingsSubMenu.Visible = false;

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
                _currentChildForm.Close();

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
      
        private void PersonalSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится на этапе разработки");
            HideSubMenu();
        }

        private void FireDetectorSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится на этапе разработки");
            HideSubMenu();
        }

        private void AccessLevelSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится на этапе разработки");
            HideSubMenu();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Находится на этапе разработки");
        }
    }
}
