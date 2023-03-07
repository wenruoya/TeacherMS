using Common;
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

namespace TeacherMS.View
{
    public partial class IndexView : UserControl
    {
        public IndexView()
        {
        }

        public IndexView(Teacher teacher)
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                labelTeacher.Text = AppData.CurrentUser.Name;
            };
        }


    }
}
