using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherMS.View
{
    public partial class QueryStudentScoreView : UserControl
    {
        public QueryStudentScoreView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                comboBoxScore.DataSource = new TestService().Select();
                comboBoxScore.DisplayMember = "Name";
            };

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            var model = new Score();
            var test = comboBoxScore.SelectedItem as Test;
            if (test != null)
            {
                model.TestId = test.Id;
                model.TestName = test.Name;
            }
            var list = new ScoreService().Select().FindAll(t => t.TestId == model.TestId);
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Score();
            var test = comboBoxScore.SelectedItem as Test;
            if (test != null)
            {
                model.TestId = test.Id;
                model.TestName = test.Name;
            }

            var subjects = new SubjectService().Select();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("学生");
            foreach (var item in subjects)
            {
                dataTable.Columns.Add(item.Name);
            }

            var students = new StudentService().Select();
            var list = new ScoreService().Select().FindAll(t=>t.TestId == model.TestId);
            foreach (var student in students)
            {
                var studentScores = list.FindAll(s => s.StudentId == student.Id);
                DataRow row = dataTable.NewRow();
                row[0] = student.Name;
                int Index = 1;
                foreach (var subject in subjects)
                {
                    var score = studentScores.FirstOrDefault(s => s.StudentId == student.Id && s.SubjectId == subject.Id);
                    if(score != null) 
                        row[Index++] =score.ScoreValue; 
                    else
                        row[Index++] =0;
                }
                dataTable.Rows.Add(row);
            }

            dataTable.Columns.Add("总分");
            dataTable.Columns.Add("平均分");
            //每个人
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                var sum = 0.0;
                for (int j = 1; j < dataTable.Columns.Count -2; j++)
                {
                    sum += float.Parse(dataTable.Rows[j][i].ToString());

                }
                var avarage = sum / 2;
                row[dataTable.Columns.Count-2] = sum;
                row[dataTable.Columns.Count-1] = avarage;

            }

            //每一科
            dataTable.Rows.Add();
            for (int i = 1; i < dataTable.Columns.Count - 2; i++)
            {
                DataColumn column = dataTable.Columns[i];
                float sum = 0;
                for (int j = 0; j < dataTable.Rows.Count - 1; j++)
                {
                    sum += float.Parse(dataTable.Rows[j][i].ToString());
                }
                dataTable.Rows[dataTable.Rows.Count][i] = sum;
            }

            dataGridView1.DataSource = dataTable;

            
        }
    }
}
