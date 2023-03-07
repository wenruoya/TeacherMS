namespace TeacherMS.View
{
    partial class IndexView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTeacher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTeacher.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTeacher.ForeColor = System.Drawing.Color.Orange;
            this.labelTeacher.Location = new System.Drawing.Point(3, 29);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(157, 57);
            this.labelTeacher.TabIndex = 1;
            this.labelTeacher.Text = "某某某";
            this.labelTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(156, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "欢迎进入本系统";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTeacher);
            this.Name = "IndexView";
            this.Size = new System.Drawing.Size(487, 128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label label2;
    }
}
