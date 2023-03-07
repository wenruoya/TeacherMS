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
    public partial class EditSubjectDesignForm : Form
    {
        private SubjectDesign model;

        public EditSubjectDesignForm(SubjectDesign model)
        {
            this.model = model;
            InitializeComponent();
            
            Load += (s, e) =>
            {

                comboBoxSubjectName.DataSource = new SubjectService().Select();
                comboBoxSubjectName.DisplayMember = "Name";
                comboBoxSubjectName.Text = model.SubjectName;
                
                comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacherName.DisplayMember = "Name";
                comboBoxTeacherName.Text = model.TeacherName;

                textBoxLabName.Text = model.Name;
                richTextBoxLab.Text = model.Content;

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            model.Name = textBoxLabName.Text.Trim();
            model.Content = richTextBoxLab.Text;
            model.DesignDate = dateTimePicker1.Value;
            model.InsertDate = DateTime.Now;

            if (model.TeacherId == 0) { MessageBox.Show("请选择老师"); return; };
            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("名字不能空"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("内容不能空"); return; };

            int result = new SubjectDesignService().Update(model);
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
