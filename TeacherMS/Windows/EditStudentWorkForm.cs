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
    public partial class EditStudentWorkForm : Form
    {
        private StudentWork model;

        public EditStudentWorkForm(StudentWork model)
        {
            InitializeComponent();
            this.model = model;
            Load += (s, e) =>
            {

                comboBoxStuName.DataSource = new StudentService().Select();
                comboBoxStuName.DisplayMember = "Name";
                comboBoxStuName.Text = model.StudentName;
                textBoxLabName.Text = model.Name;
                textBoxAddr.Text = model.Address;
                dateTimeLabTime.Value = model.WorkDate.Value;
                richTextBoxLab.Text = model.Content;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = comboBoxStuName.SelectedItem as Student;
            if (student != null)
            {
                model.Student = student.Id;
                model.StudentName = student.Name;
            }

            model.Address = textBoxAddr.Text.Trim();
            model.Name = textBoxLabName.Text.Trim();
            model.Content = richTextBoxLab.Text;
            model.WorkDate = dateTimeLabTime.Value;
            model.InsertDate = DateTime.Now;

            if (model.Student == 0) { MessageBox.Show("请选择学生"); return; };

            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("实习报告不能空"); return; };
            if (string.IsNullOrEmpty(model.Content)) { MessageBox.Show("报告内容不能空"); return; };

            int result = new StudentWorkService().Update(model);
            if (result > 0)
            {
                MessageBox.Show("操作成功");     
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
