namespace TeacherMS.Windows
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.buttonSure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Location = new System.Drawing.Point(28, 28);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(736, 326);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = "教学管理系统（Teaching Management System ，TMS）是一种教学管理软件。该种系统面向的对象有：幼儿教育、中小学教育、高等教育、职业教育以" +
    "及培训行业。系统结合现代化教学中各个环节进行信息化集成管理，一般集成市场管理、招生管理、教学管理、文档管理、就业管理、学籍管理、考勤管理、人事管理等整体解决方案" +
    "。";
            // 
            // buttonSure
            // 
            this.buttonSure.Location = new System.Drawing.Point(509, 375);
            this.buttonSure.Name = "buttonSure";
            this.buttonSure.Size = new System.Drawing.Size(225, 50);
            this.buttonSure.TabIndex = 1;
            this.buttonSure.Text = "确认";
            this.buttonSure.UseVisualStyleBackColor = true;
            this.buttonSure.Click += new System.EventHandler(this.buttonSure_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSure);
            this.Controls.Add(this.richTextBoxHelp);
            this.Name = "HelpForm";
            this.Text = "帮助";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.Button buttonSure;
    }
}