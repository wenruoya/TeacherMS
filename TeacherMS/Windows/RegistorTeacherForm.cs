using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherMS.Windows
{
    public partial class RegistorTeacherForm : Form
    {
        public RegistorTeacherForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            teacher.Name = textBoxName.Text.Trim();
            teacher.Number = textBoxNumber.Text.Trim();
            teacher.Password = textBoxPass.Text.Trim();
            teacher.Telephone = textBoxTel.Text.Trim();
            teacher.Sex = comboBoxSex.Text.Trim();
            teacher.Email = textBoxEmail.Text.Trim();
            teacher.JobTitle = textBoxPost.Text.Trim();
            teacher.Addresss = textBoxAddr.Text.Trim();
            teacher.Role = 1;
            teacher.InsertData = DateTime.Now;

            if (string.IsNullOrEmpty(teacher.Name)) MessageBox.Show("名字不能为空");
            if (string.IsNullOrEmpty(teacher.Password)) MessageBox.Show("密码不能为空");
            int count = new TeacherServiceL().Insert(teacher);
            if (count > 0)
            {
                MessageBox.Show("操作成功");            
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
