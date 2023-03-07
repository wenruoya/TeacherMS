namespace TeacherMS.Windows
{
    partial class EditSubjectDesignForm
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
            this.richTextBoxLab = new System.Windows.Forms.RichTextBox();
            this.textBoxLabName = new System.Windows.Forms.TextBox();
            this.comboBoxSubjectName = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxLab
            // 
            this.richTextBoxLab.Location = new System.Drawing.Point(155, 164);
            this.richTextBoxLab.Name = "richTextBoxLab";
            this.richTextBoxLab.Size = new System.Drawing.Size(595, 366);
            this.richTextBoxLab.TabIndex = 34;
            this.richTextBoxLab.Text = "";
            // 
            // textBoxLabName
            // 
            this.textBoxLabName.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLabName.Location = new System.Drawing.Point(518, 27);
            this.textBoxLabName.Name = "textBoxLabName";
            this.textBoxLabName.Size = new System.Drawing.Size(232, 44);
            this.textBoxLabName.TabIndex = 33;
            // 
            // comboBoxSubjectName
            // 
            this.comboBoxSubjectName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSubjectName.FormattingEnabled = true;
            this.comboBoxSubjectName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxSubjectName.Location = new System.Drawing.Point(155, 37);
            this.comboBoxSubjectName.Name = "comboBoxSubjectName";
            this.comboBoxSubjectName.Size = new System.Drawing.Size(220, 36);
            this.comboBoxSubjectName.TabIndex = 32;
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxTeacherName.Location = new System.Drawing.Point(155, 90);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(220, 36);
            this.comboBoxTeacherName.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(26, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 36);
            this.label8.TabIndex = 30;
            this.label8.Text = "实验内容";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(381, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 29;
            this.label6.Text = "课程名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(18, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "指导老师";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 26;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "所属课程";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(536, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(392, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "设计时间";
            // 
            // EditSubjectDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 646);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxLab);
            this.Controls.Add(this.textBoxLabName);
            this.Controls.Add(this.comboBoxSubjectName);
            this.Controls.Add(this.comboBoxTeacherName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "EditSubjectDesignForm";
            this.Text = "修改课程设计";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLab;
        private System.Windows.Forms.TextBox textBoxLabName;
        private System.Windows.Forms.ComboBox comboBoxSubjectName;
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}