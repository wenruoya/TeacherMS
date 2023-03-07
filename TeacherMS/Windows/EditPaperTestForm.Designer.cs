namespace TeacherMS.Windows
{
    partial class EditPaperTestForm
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
            this.dateTimePickerTestTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSubjectName = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSumScore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxClassName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerTestTime
            // 
            this.dateTimePickerTestTime.Location = new System.Drawing.Point(210, 420);
            this.dateTimePickerTestTime.Name = "dateTimePickerTestTime";
            this.dateTimePickerTestTime.Size = new System.Drawing.Size(228, 28);
            this.dateTimePickerTestTime.TabIndex = 38;
            // 
            // comboBoxSubjectName
            // 
            this.comboBoxSubjectName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSubjectName.FormattingEnabled = true;
            this.comboBoxSubjectName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSubjectName.Location = new System.Drawing.Point(206, 123);
            this.comboBoxSubjectName.Name = "comboBoxSubjectName";
            this.comboBoxSubjectName.Size = new System.Drawing.Size(232, 36);
            this.comboBoxSubjectName.TabIndex = 37;
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxTeacherName.Location = new System.Drawing.Point(206, 193);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(232, 36);
            this.comboBoxTeacherName.TabIndex = 36;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxName.Location = new System.Drawing.Point(210, 488);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 44);
            this.textBoxName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(73, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "考试时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(73, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 36);
            this.label8.TabIndex = 33;
            this.label8.Text = "试卷名字";
            // 
            // textBoxSumScore
            // 
            this.textBoxSumScore.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSumScore.Location = new System.Drawing.Point(206, 336);
            this.textBoxSumScore.Name = "textBoxSumScore";
            this.textBoxSumScore.Size = new System.Drawing.Size(232, 44);
            this.textBoxSumScore.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(92, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(73, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 30;
            this.label5.Text = "专业老师";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxClassName
            // 
            this.comboBoxClassName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxClassName.FormattingEnabled = true;
            this.comboBoxClassName.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五"});
            this.comboBoxClassName.Location = new System.Drawing.Point(206, 54);
            this.comboBoxClassName.Name = "comboBoxClassName";
            this.comboBoxClassName.Size = new System.Drawing.Size(232, 36);
            this.comboBoxClassName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(92, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 28;
            this.label4.Text = "总分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "所属课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "所属班级";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCount.Location = new System.Drawing.Point(206, 268);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(232, 44);
            this.textBoxCount.TabIndex = 39;
            // 
            // EditPaperTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 712);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.dateTimePickerTestTime);
            this.Controls.Add(this.comboBoxSubjectName);
            this.Controls.Add(this.comboBoxTeacherName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSumScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxClassName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditPaperTestForm";
            this.Text = "修改试卷";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTestTime;
        private System.Windows.Forms.ComboBox comboBoxSubjectName;
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSumScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCount;
    }
}