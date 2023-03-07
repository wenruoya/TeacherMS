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
using TeacherMS.Windows;

namespace TeacherMS.View
{
    public partial class ScoreView : UserControl
    {
        public ScoreView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new ScoreService().Select();

                comboBoxScore.DataSource = new TestService().Select();
                comboBoxScore.DisplayMember = "Name";

                comboBoxSubject.DataSource = new SubjectService().Select();
                comboBoxSubject.DisplayMember = "Name";

                comboBoxStuName.DataSource = new StudentService().Select();
                comboBoxStuName.DisplayMember = "Name";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Score();

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
            // 此处 分数要小于课程设置的最高分
            if(float.TryParse(textBoxScore.Text.Trim(),out float score))
            {
                if (score >= 0 && score <= subject.Score) 
                { 
                    model.ScoreValue = score;
                }
                else
                {
                    MessageBox.Show("分数不对");return;
                }

            }
            else
            {
                MessageBox.Show("分数不对"); return;
            }
            model.InsertDate = DateTime.Now;
            if(test.Id == 0)
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


            int count = new ScoreService().Insert(model);
            if (count > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new ScoreService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Score>;
                var model = list[index];
                var EditStudentForm = new EditScoreForm(model);
                var result = EditStudentForm.ShowDialog();
                dataGridView.DataSource = new ScoreService().Select();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("您确定要删除吗？", "", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Score>;
                var model = list[index];
                var count = new ScoreService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new ScoreService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new ScoreService().Select();
        }

       
    }
}
