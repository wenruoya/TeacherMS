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
    public partial class StudyCalenderView : UserControl
    {
        public StudyCalenderView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new StudyCalenderService().Select();
                comboBoxTeacher.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacher.DisplayMember = "Name";
            };
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var model = new StudyCalender();

            var teacher = comboBoxTeacher.SelectedItem as Teacher;
            if (teacher != null)
            {
                model.TearcherId = teacher.Id;
                model.TearcherName = teacher.Name;
            }
            model.Monday = richTexMonday.Text.Trim();
            model.Saturday= richTextBoxSaturday.Text.Trim();
            model.Thursday = richTextBoxThursday.Text.Trim();
            model.Tuesday = richTextTuesday.Text.Trim();
            model.Friday = richTextBoxFiriday.Text.Trim();
            model.Sunday = richTextBoxSunday.Text.Trim();
            model.Wednesday = richTextWednesday.Text.Trim();
            model.InsertDate = DateTime.Now;

            if (model.TearcherId == 0) { MessageBox.Show("请选择老师"); return; }

            if(model.Monday.Length>0
                ||model.Saturday.Length>0
                ||model.Thursday.Length>0
                ||model.Tuesday.Length > 0
                || model.Friday.Length > 0
                || model.Sunday.Length > 0
                || model.Wednesday.Length > 0)
            {
                if (string.IsNullOrEmpty(model.TearcherName)) MessageBox.Show("名字不能为空");
                int count = new StudyCalenderService().Insert(model);
                if (count > 0)
                {
                    MessageBox.Show("操作成功");
                    dataGridView.DataSource = new StudyCalenderService().Select();
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            else
            {
                MessageBox.Show("名字不能为空");
            }
        }
        //全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new StudyCalenderService().Select();
        }
        //编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<StudyCalender>;
                var model = list[index];
                var Form = new EditStudyCalenderForm(model);
                var result = Form.ShowDialog();
                dataGridView.DataSource = new StudyCalenderService().Select();
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
                var list = dataGridView.DataSource as List<StudyCalender>;
                var model = list[index];
                var count = new StudyCalenderService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new StudyCalenderService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }
    }
}
