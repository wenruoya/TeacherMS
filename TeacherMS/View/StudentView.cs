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
    public partial class StudentView : UserControl
    {
        public StudentView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new StudentService().Select();
                var classes = new ClassService().Select();
                comboBoxClass.DataSource = classes;
                comboBoxClass.DisplayMember = "Name";
            };
        }
        //添加学生
        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student();

            var @class = comboBoxClass.SelectedItem as Class;
            if (@class == null) return;

            student.ClassId = @class.Id;
            
            student.ClassName = @class.Name;

            student.Name = textBoxName.Text.Trim();
            student.Number = textBoxNumber.Text.Trim();
            student.Sex = comboBoxSex.Text.Trim();
            student.Telephone = textBoxTel.Text.Trim();
            student.Email = textBoxMail.Text.Trim();
            student.Address = textBoxAddr.Text.Trim();
            student.InsertDate = DateTime.Now;

            if (string.IsNullOrEmpty(student.Name)) MessageBox.Show("名字不能为空");
            int count = new StudentService().Insert(student);
            if (count > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new StudentService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
        //编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Student>;
                var model = list[index];
                var EditStudentForm = new EditStudentForm(model);
                var result = EditStudentForm.ShowDialog();
                dataGridView.DataSource = new StudentService().Select();
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
                var list = dataGridView.DataSource as List<Student>;
                var model = list[index];
                var count = new StudentService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new StudentService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new StudentService().Select();
        }
    }
}
