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
    public partial class StudentWorkView : UserControl
    {
        public StudentWorkView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new StudentWorkService().Select();

                comboBoxStuName.DataSource = new StudentService().Select();
                comboBoxStuName.DisplayMember = "Name";

            };
        }
        //添加
        private void button1_Click(object sender, EventArgs e)
        {
            var model = new StudentWork();

            var student = comboBoxStuName.SelectedItem as Student;
            if (student != null)
            {
                model.Student = student.Id;
                model.StudentName = student.Name;
            }

            model.Address = textBoxAddr.Text.Trim();
            model.Name = textBoxLabName.Text.Trim();
            model.Content = richTextBoxLab.Text;
            model.WorkDate = dateTimeLabTime.Value;
            model.InsertDate = DateTime.Now;

            if (model.Student == 0) { MessageBox.Show("请选择学生"); return; };

            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("实习报告不能空"); return; };
            if (string.IsNullOrEmpty(model.Content)) { MessageBox.Show("报告内容不能空"); return; };

            int result = new StudentWorkService().Insert(model);
            if (result > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new StudentWorkService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
        //全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new StudentWorkService().Select();
        }
        // 编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<StudentWork>;
                var model = list[index];
                var Form = new EditStudentWorkForm(model);
                var result = Form.ShowDialog();
                dataGridView.DataSource = new StudentWorkService().Select();
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
                var list = dataGridView.DataSource as List<StudentWork>;
                var model = list[index];
                var count = new StudentWorkService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new StudentWorkService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    
            
    
    }
}
