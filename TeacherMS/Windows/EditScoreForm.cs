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
    public partial class EditScoreForm : Form
    {
        private Score model = null;

        public EditScoreForm(Score model)
        {
            InitializeComponent();
            this.model = model;
            Load += (s, e) =>
            {
                comboBoxScore.DataSource = new TestService().Select();
                comboBoxScore.DisplayMember = "Name";
                comboBoxScore.Text = model.TestName;

                comboBoxStuName.DataSource = new StudentService().Select();
                comboBoxStuName.DisplayMember = "Name";
                comboBoxStuName.Text = model.StudentName;

                comboBoxSubject.DataSource = new SubjectService().Select();
                comboBoxSubject.DisplayMember = "Name";
                comboBoxSubject.Text = model.SubjectName;
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var subject = comboBoxSubject.SelectedItem as Subject;
            if (subject != null)
            {
                model.SubjectId = subject.Id;
                model.SubjectName = subject.Name;
            }
            var test = comboBoxScore.SelectedItem as Test;
            if (test != null)
            {
                model.TestId = subject.Id;
                model.TestName = subject.Name;
            }
            var student = comboBoxStuName.SelectedItem as Student;
            if (student != null)
            {
                model.StudentId = student.Id;
                model.StudentName = student.Name;
            }

            if (float.TryParse(textBoxScore.Text.Trim(), out float score))
            {
                if (score >= 0 && score <= subject.Score)
                {
                    model.ScoreValue = score;
                }
                else
                {
                    MessageBox.Show("分数不对"); return;
                }
            }
            else
            {
                MessageBox.Show("分数不对"); return;
            }

            student.InsertDate = DateTime.Now;

            if (test.Id == 0)
            {
                MessageBox.Show("请选择成绩单"); return;
            }
            if (model.StudentId == 0)
            {
                MessageBox.Show("请选择学生"); return;
            }
            if (model.SubjectId == 0)
            {
                MessageBox.Show("请选择课程"); return;
            }


            int count = new ScoreService().Update(model);
            if (count > 0)
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
