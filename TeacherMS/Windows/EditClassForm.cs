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
    public partial class EditClassForm : Form
    {
        private Class @class = null;
        public EditClassForm(Class @class)
        {
            InitializeComponent();
            this.@class = @class;

            Load += (s, e) =>
            {
                textBoxUserName.Text = @class.Name;
                comboBoxYear.Text = @class.Grade;
                comboBoxClass.Text = @class.Class1;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                @class.Name = textBoxUserName.Text.Trim();
                @class.Grade = comboBoxYear.Text.Trim();
                @class.Class1 = comboBoxClass.Text.Trim();
                if (string.IsNullOrEmpty(@class.Name)) MessageBox.Show("名字不能为空");
                var count = new ClassService().Update(@class);
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
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
    }
}
