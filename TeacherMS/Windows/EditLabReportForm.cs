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
    public partial class EditLabReportForm : Form
    {
        private LabReport model;

        public EditLabReportForm(LabReport model)
        {
            InitializeComponent();
            this.model = model;
            Load += (s, e) =>
            {

                comboBoxStuName.DataSource = new StudentService().Select();
                comboBoxStuName.DisplayMember = "Name";
                comboBoxStuName.Text = model.Name; 

                comboBoxSubjectName.DataSource = new SubjectService().Select();
                comboBoxSubjectName.DisplayMember = "Name";
                comboBoxSubjectName.Text = model.SubjectName;

                comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacherName.DisplayMember = "Name";
                comboBoxTeacherName.Text = model.TeacherName;

                textBoxLabName.Text = model.Name;
                dateTimeLabTime.Value = model.LabDate.Value;
                richTextBoxLab.Text = model.Content;

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var student = comboBoxStuName.SelectedItem as Student;
            if (student != null)
            {
                model.StudentId = student.Id;
                model.StudentName = student.Name;
            }
            var subject = comboBoxSubjectName.SelectedItem as Subject;
            if (subject != null)
            {
                model.SubjectId = subject.Id;
                model.SubjectName = subject.Name;
            }
            var teacher = comboBoxTeacherName.SelectedItem as Teacher;
            if (teacher != null)
            {
                model.TeacherId = teacher.Id;
                model.TeacherName = teacher.Name;
            }
            model.LabDate = dateTimeLabTime.Value;
            model.Name = textBoxLabName.Text.Trim();

            if (model.TeacherId == 0) { MessageBox.Show("请选择老师"); return; };
            if (model.StudentId == 0) { MessageBox.Show("请选择学生"); return; };
            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("实验名字不能空"); return; };

            int result = new LabReportService().Update(model);
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
