using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherMS.Windows;

namespace TeacherMS.View
{
    public partial class ClassView : UserControl
    {
        public ClassView()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new ClassService().Select();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new ClassService();
            var @class = new Class();
            @class.Name  = textBoxUserName.Text.Trim();
            @class.Grade = comboBoxYear.Text.Trim();
            @class.Class1 = comboBoxClass.Text.Trim();
            @class.InsertDate = DateTime.Now;
            if (string.IsNullOrEmpty(@class.Name)) MessageBox.Show("名字不能为空");
            int count = service.Insert(@class);
            if (count > 0 )
            {
                MessageBox.Show("操作成功");
                dataGridView.DataSource = service.Select();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        // 全部
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = new ClassService().Select();

        }
        // 编辑
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Class>;
                var model = list[index];
                var EditClassForm = new EditClassForm(model);
                var result = EditClassForm.ShowDialog();
                dataGridView.DataSource = new ClassService().Select();
            }
        }
        // 删除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("您确定要删除吗？","",MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var rows = dataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Class>;
                var model = list[index];
                var count = new ClassService().Delete(model);
                if(count> 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new ClassService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }
        


        
    }
}
