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
    public partial class EditMaterialForm : Form
    {
        private Material model;

        public EditMaterialForm(Material model)
        {
            InitializeComponent();
            this.model = model;
            Load += (s, e) =>
            {
                comboBoxSubject.DataSource = new SubjectService().Select();
                comboBoxSubject.DisplayMember = "Name";

                textBoxClassName.Text = model.Name;
                textBoxAuthor.Text = model.AuthorName;
                textBoxSource.Text = model.Source;
                richTextBoxCent.Text = model.Content;
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

            model.Name = textBoxClassName.Text.Trim();
            model.Content = richTextBoxCent.Text;
            model.AuthorName = textBoxAuthor.Text.Trim();
            model.Source = textBoxSource.Text.Trim();

            model.InsertDate = DateTime.Now;


            if (model.SubjectId == 0) { MessageBox.Show("请选择课程"); return; };
            if (string.IsNullOrEmpty(model.Name)) { MessageBox.Show("名字不能空"); return; };
            if (string.IsNullOrEmpty(model.Content)) { MessageBox.Show("内容不能空"); return; };

            int result = new MaterialService().Update(model);
            if (result > 0)
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
