namespace TeacherMS.Windows
{
    partial class EditScoreForm
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
            this.comboBoxStuName = new System.Windows.Forms.ComboBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxScore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxStuName
            // 
            this.comboBoxStuName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStuName.FormattingEnabled = true;
            this.comboBoxStuName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxStuName.Location = new System.Drawing.Point(185, 136);
            this.comboBoxStuName.Name = "comboBoxStuName";
            this.comboBoxStuName.Size = new System.Drawing.Size(232, 36);
            this.comboBoxStuName.TabIndex = 25;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxScore.Location = new System.Drawing.Point(185, 268);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(232, 44);
            this.textBoxScore.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(83, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "课程";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSubject.Location = new System.Drawing.Point(185, 200);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(232, 36);
            this.comboBoxSubject.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxScore
            // 
            this.comboBoxScore.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxScore.FormattingEnabled = true;
            this.comboBoxScore.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五"});
            this.comboBoxScore.Location = new System.Drawing.Point(186, 71);
            this.comboBoxScore.Name = "comboBoxScore";
            this.comboBoxScore.Size = new System.Drawing.Size(232, 36);
            this.comboBoxScore.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(83, 276);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "分数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "学生姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "成绩单";
            // 
            // EditScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 528);
            this.Controls.Add(this.comboBoxStuName);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditScoreForm";
            this.Text = "编辑成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStuName;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}