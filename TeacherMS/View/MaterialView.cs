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
    public partial class MaterialView : UserControl
    {
        public MaterialView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new MaterialService().Select();

                comboBoxSubject.DataSource = new SubjectService().Select();
                comboBoxSubject.DisplayMember = "Name";

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new Material();

            var subject = comboBoxSubject.SelectedItem as Subject;
            if (subject != null)
            {
                model.SubjectId = subject.Id;
                model.SubjectName = subject.Name;
            }
         
            model.Name = textBoxClassName.Text.Trim();
            model.Content = richTextBoxCent.Text;
            model.AuthorName = textBoxAuthor.Text.Trim();
            model.Source = textBoxSource.Text.Trim();

            model.InsertDate = DateTime.Now;


            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("名字不能空"); return; };
            if (string.IsNullOrEmpty(model.Content)) { MessageBox.Show("内容不能空"); return; };

            int result = new MaterialService().Insert(model);
            if (result > 0)
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = new LabReportService().Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
        //全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new MaterialService().Select();
        }
        //编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Material>;
                var model = list[index];
                var Form = new EditMaterialForm(model);
                var result = Form.ShowDialog();
                dataGridView.DataSource = new MaterialService().Select();
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
                var list = dataGridView.DataSource as List<Material>;
                var model = list[index];
                var count = new MaterialService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new MaterialService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
}
