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
    public partial class SubjectDesignView : UserControl
    {
        public SubjectDesignView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {   
                dataGridView.DataSource = new SubjectDesignService().Select();


                comboBoxSubjectName.DataSource = new SubjectService().Select();
                comboBoxSubjectName.DisplayMember = "Name";

                comboBoxTeacherName.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacherName.DisplayMember = "Name";
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new SubjectDesign();

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

            int result = new SubjectDesignService().Insert(model);
            if (result > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new SubjectDesignService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
        //全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new SubjectDesignService().Select();

        }
        //编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<SubjectDesign>;
                var model = list[index];
                var Form = new EditSubjectDesignForm(model);
                var result = Form.ShowDialog();
                dataGridView.DataSource = new SubjectDesignService().Select();
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
                var list = dataGridView.DataSource as List<SubjectDesign>;
                var model = list[index];
                var count = new SubjectDesignService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new SubjectDesignService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
}
