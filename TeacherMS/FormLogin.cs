using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherMS.Windows;

namespace TeacherMS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxRole.Text.Trim())) return;

            var role = comboBoxRole.SelectedIndex;    
            var username = textBoxUserName.Text.Trim();
            var password = textBoxPassword.Text.Trim();
            TeacherServiceL tearcherService = new TeacherServiceL();
            var user = tearcherService.Select().FirstOrDefault(t => t.Name == username && t.Password == password &&t.Role == role);
            if(user == null)
            {
                MessageBox.Show("用户名密码或角色错误");
            }
            else
            {
                AppData.CurrentUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
          
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            var result = new RegistorTeacherForm().ShowDialog();
        }
    }
}
