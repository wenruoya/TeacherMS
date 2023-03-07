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
    public partial class SubjectView : UserControl
    {
        public SubjectView()
        {
            InitializeComponent();
            Load += (s, e)=>{
                dataGridView.DataSource = new SubjectService().Select();
                comboBoxTeacher.DataSource = new TeacherServiceL().Select().FindAll(t=>t.Role> 0);
                comboBoxTeacher.DisplayMember = "Name";
            };
        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Subject();

            var teacher = comboBoxTeacher.SelectedItem as Teacher;
            if (teacher != null) {
                model.TeacherId = teacher.Id;
                model.TeacherName = teacher.Name;
            }
            model.Name = textBoxClassName.Text.Trim();
            
            model.Code = textBoxClassCode.Text;


            if (int.TryParse(textBoxSocros.Text.Trim(), out int score))
                model.Score = score;

            model.Date = dateTimePicker1.Value;

            if (int.TryParse(textBoxPeople.Text.Trim(), out int Current))
                model.CurrentStudent = Current;

            if (int.TryParse(textBoxMax.Text.Trim(), out int Max))
                model.Capacity = Max;

            model.Info = textBoxintro.Text.Trim();
            model.InsertDate = DateTime.Now;

            int count = new SubjectService().Insert(model);
            if (count > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new SubjectService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
        // 编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Subject>;
                var model = list[index];
                var EditSubjectForm = new EditSubjectForm(model);
                var result = EditSubjectForm.ShowDialog();
                dataGridView.DataSource = new SubjectService().Select();
            }
        }
        //删除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("您确定要删除吗？", "", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Subject>;
                var model = list[index];
                var count = new SubjectService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new SubjectService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }
    }
}
