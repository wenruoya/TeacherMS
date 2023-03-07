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
    public partial class EditPaperTestForm : Form
    {
        private PaperTest model;
        public EditPaperTestForm(PaperTest model)
        {
            InitializeComponent();
            this.model = model;
            Load += (s, e) =>
            {

                comboBoxClassName.DataSource = new ClassService().Select();
                comboBoxClassName.DisplayMember = "Name";

                comboBoxSubjectName.DataSource = new SubjectService().Select();
                comboBoxSubjectName.DisplayMember = "Name";

                comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacherName.DisplayMember = "Name";

                textBoxCount.Text = model.Count.ToString();
                textBoxSumScore.Text = model.SumScore.ToString();
                dateTimePickerTestTime.Value = (DateTime)model.TestTime;
                textBoxName.Text = model.Name;


            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var @class = comboBoxClassName.SelectedItem as Class;
            if (@class != null)
            {
                model.ClassId = @class.Id;
                model.Name = @class.Name;
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
            if (int.TryParse(textBoxCount.Text.Trim(), out int count))
            {
                model.Count = count;

            }
            if (int.TryParse(textBoxSumScore.Text.Trim(), out int sumScore))
            {
                model.SumScore = sumScore;

            }
            model.TestTime = dateTimePickerTestTime.Value;
            model.Name = textBoxName.Text.Trim();

            if (model.TeacherId == 0) { MessageBox.Show("请选择老师"); return; };
            if (model.ClassId == 0) { MessageBox.Show("请选择班级"); return; };
            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("试卷名字不能空"); return; };

            int result = new PaperTestService().Update(model);
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
