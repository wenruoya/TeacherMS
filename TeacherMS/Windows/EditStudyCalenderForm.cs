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
    public partial class EditStudyCalenderForm : Form
    {
        private StudyCalender model;

        public EditStudyCalenderForm(StudyCalender model)
        {
            InitializeComponent();
            this.model = model;

            Load += (s, e) =>
            {
                if (model == null) return;
                comboBoxTeacher.DataSource = new TeacherServiceL().Select().FindAll(t => t.Role > 0);
                comboBoxTeacher.DisplayMember = "Name";

                richTexMonday.Text = model.Monday;
                richTextBoxFiriday.Text = model.Friday;
                richTextBoxSaturday.Text = model.Saturday;
                richTextBoxSunday.Text = model.Sunday;
                richTextBoxThursday.Text = model.Thursday;
                richTextTuesday.Text = model.Tuesday;
                richTextWednesday.Text = model.Wednesday;
            };
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
          
            var teacher = comboBoxTeacher.SelectedItem as Teacher;
            if (teacher != null)
            {
                model.TearcherId = teacher.Id;
                model.TearcherName = teacher.Name;
            }
            model.Monday = richTexMonday.Text.Trim();
            model.Saturday = richTextBoxSaturday.Text.Trim();
            model.Thursday = richTextBoxThursday.Text.Trim();
            model.Tuesday = richTextTuesday.Text.Trim();
            model.Friday = richTextBoxFiriday.Text.Trim();
            model.Sunday = richTextBoxSunday.Text.Trim();
            model.Wednesday = richTextWednesday.Text.Trim();
            model.InsertDate = DateTime.Now;

            if (model.TearcherId == 0) { MessageBox.Show("请选择老师"); return; }

            if (model.Monday.Length > 0
                || model.Saturday.Length > 0
                || model.Thursday.Length > 0
                || model.Tuesday.Length > 0
                || model.Friday.Length > 0
                || model.Sunday.Length > 0
                || model.Wednesday.Length > 0)
            {
                if (string.IsNullOrEmpty(model.TearcherName)) MessageBox.Show("名字不能为空");
                int count = new StudyCalenderService().Update(model);
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
            else
            {
                MessageBox.Show("名字不能为空");
            }

        }
    }
}
