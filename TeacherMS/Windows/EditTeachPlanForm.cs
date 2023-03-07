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
    public partial class EditTeachPlanForm : Form
    {
        private TeachPlan model;

        public EditTeachPlanForm(TeachPlan model)
        {
            InitializeComponent();
            this.model = model;

            comboBoxSubject.DataSource = new SubjectService().Select();
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.Text = model.SubjectName;

            comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
            comboBoxTeacherName.DisplayMember = "Name";
            comboBoxTeacherName.Text = model.TeacherName;

            textBoxPlanName.Text = model.Name;
            richTextBoxCent.Text = model.Content;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var subject = comboBoxSubject.SelectedItem as Subject;
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

            model.Name = textBoxPlanName.Text.Trim();
            model.Content = richTextBoxCent.Text;
            model.InsertDate = DateTime.Now;

            if (model.TeacherId == 0) { MessageBox.Show("请选择老师"); return; };
            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("名字不能空"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("内容不能空"); return; };

            int result = new TeachPlanService().Update(model);
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
