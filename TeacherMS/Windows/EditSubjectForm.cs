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
    public partial class EditSubjectForm : Form
    {
        private Subject model = null;
        public EditSubjectForm(Subject model)
        {
            InitializeComponent();

            this.model = model;
            Load += (s, e) =>{
                var list = new SubjectService().Select();
                comboBoxTeacher.DataSource = list;
                comboBoxTeacher.DisplayMember = "Name";

                comboBoxTeacher.Text = model.TeacherName;
                textBoxClassName.Text = model.Name;
                textBoxClassCode.Text = model.Code;
                textBoxSocros.Text = model.Score.ToString();
                dateTimePicker1.Value = (DateTime)model.Date;
                textBoxPeople.Text = model.CurrentStudent.ToString();
                textBoxMax.Text = model.Capacity.ToString();
                textBoxintro.Text = model.Info;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var teacher = comboBoxTeacher.SelectedItem as Teacher;
            if (teacher != null)
            {
                model.TeacherId = teacher.Id;
                model.TeacherName = teacher.Name;
            }
            model.Name = textBoxClassName.Text.Trim();

            model.Code = textBoxClassCode.Text;


            if (int.TryParse(textBoxSocros.Text.Trim(), out int score)) { model.Score = score; }
                

            model.Date = dateTimePicker1.Value;

            if (int.TryParse(textBoxPeople.Text.Trim(), out int Current))
                model.CurrentStudent = Current;

            if (int.TryParse(textBoxMax.Text.Trim(), out int Max))
                model.Capacity = Max;

            model.Info = textBoxintro.Text.Trim();
            model.InsertDate = DateTime.Now;

            int count = new SubjectService().Update(model);
            if (count > 0)
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
