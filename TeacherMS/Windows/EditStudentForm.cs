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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TeacherMS.Windows
{
    public partial class EditStudentForm : Form
    {
        private Student model = null;
        public EditStudentForm(Student model)
        {
            InitializeComponent();
            this.model = model;

            Load += (s, e) =>
            {
                var classes = new ClassService().Select();
                comboBoxClass.DataSource = classes;
                comboBoxClass.DisplayMember = "Name";
                comboBoxClass.Text = model.ClassName;


                textBoxName.Text = model.Name;
                textBoxNumber.Text = model.Number;
                comboBoxSex.Text = model.Sex;
                textBoxTel.Text =  model.Telephone;
                textBoxMail.Text = model.Email;
                textBoxAddr.Text = model.Address;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var @class = comboBoxClass.SelectedItem as Class;
                if (@class == null) return;
                model.ClassId = @class.Id;
                model.ClassName = @class.Name;

                model.ClassName = comboBoxClass.Text.Trim();
                model.Name = textBoxName.Text.Trim();
                model.Number = textBoxNumber.Text.Trim();
                model.Sex = comboBoxSex.Text.Trim();
                model.Telephone = textBoxTel.Text.Trim();
                model.Email = textBoxMail.Text.Trim();
                model.Address = textBoxMail.Text.Trim();

                if (string.IsNullOrEmpty(model.Name)) MessageBox.Show("名字不能为空");
                var count = new StudentService().Update(model);
                if (count > 0)
                {
                    MessageBox.Show("修改成功");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
