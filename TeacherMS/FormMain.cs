using Common;
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
using TeacherMS.Windows;

namespace TeacherMS
{
    public partial class FormMain : Form
    {
        private FormLogin formLogin = new FormLogin();
        public FormMain()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                var result = formLogin.ShowDialog();
                if(result != DialogResult.OK)this.Close();
                if (AppData.CurrentUser == null) return; 
                this.Text = $"教研室教学资料管理系统 - 当前用户:{AppData.CurrentUser.Name}";
                // 将自定义的IndexView引入 主界面
                var indexView = new  IndexView();
                indexView.Dock = DockStyle.Fill;
                Container.Controls.Add(indexView);
            };
        }


        private void 班级设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new ClassView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new StudentView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new SubjectView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 试卷管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new PaperTestView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 实验报告管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new LabReportView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 课程设计管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new SubjectDesignView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 联系我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutMeForm().ShowDialog();
        }

        private void 成绩单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TestForm().ShowDialog();
        }

        private void 录入学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new ScoreView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 查看学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new QueryStudentScoreView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 教学日历管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new StudyCalenderView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 实习报告管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new StudentWorkView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 教案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new TeachPlanView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }

        private void 教学资料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Controls.Clear();
            var View = new MaterialView();
            View.Dock = DockStyle.Fill;
            Container.Controls.Add(View);
        }
    }
}
