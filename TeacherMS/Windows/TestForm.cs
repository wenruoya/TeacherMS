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
using TeacherMS.View;

namespace TeacherMS.Windows
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                dataGridView.DataSource = new TestService().Select();


            };
        }
        // 添加
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var name = textBoxTest.Text.Trim();
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("请输入成绩单");return; }
            var model = new Test();
            model.Name = name;
            model.InsertDate = DateTime.Now;
            int count = new TestService().Insert(model);
            if (count > 0)
            {
                MessageBox.Show("修改成功");
                dataGridView.DataSource = new TestService().Select();
            }
            else
            {
                MessageBox.Show("修改失败");
            }

        }
        // 删除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("您确定要删除吗？", "", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var rows = dataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                var index = rows[0].Index;
                var list = dataGridView.DataSource as List<Test>;
                var model = list[index];
                var count = new TestService().Delete(model);
                if (count > 0)
                {
                    MessageBox.Show("删除成功");
                    dataGridView.DataSource = new TestService().Select();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }

            }
        }


    }
}
