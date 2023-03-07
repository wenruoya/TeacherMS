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
    public partial class PaperTestView : UserControl
    {
        public PaperTestView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new PaperTestService().Select();

                comboBoxClassName.DataSource = new ClassService().Select();
                comboBoxClassName.DisplayMember = "Name";

                comboBoxSubjectName.DataSource = new SubjectService().Select();
                comboBoxSubjectName.DisplayMember = "Name";

                comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacherName.DisplayMember = "Name";
            };
        }
        //全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new PaperTestService().Select();
        }
        //编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<PaperTest>;
                var model = list[index];
                var Form = new EditPaperTestForm(model);
                var result = Form.ShowDialog();
                dataGridView.DataSource = new PaperTestService().Select();
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
                var list = dataGridView.DataSource as List<PaperTest>;
                var model = list[index];
                var count = new PaperTestService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new PaperTestService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            var model = new PaperTest();

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
            if(int.TryParse(textBoxCount.Text.Trim(),out int count)){
                model.Count = count;

            }
            if (int.TryParse(textBoxSumScore.Text.Trim(), out int sumScore))
            {
                model.SumScore = sumScore;

            }
            model.TestTime = dateTimePickerTestTime.Value;
            model.Name = textBoxName.Text.Trim();
            model.InsertDate = DateTime.Now;

            if (model.TeacherId == 0) { MessageBox.Show("请选择老师");return; };
            if (model.ClassId == 0) { MessageBox.Show("请选择班级"); return; };
            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("试卷名字不能空"); return; };

            int result = new PaperTestService().Insert(model);
            if (result > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new PaperTestService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
