namespace TeacherMS.Windows
{
    partial class EditStudentWorkForm
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
            this.textBoxAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxLab = new System.Windows.Forms.RichTextBox();
            this.textBoxLabName = new System.Windows.Forms.TextBox();
            this.dateTimeLabTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxStuName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddr
            // 
            this.textBoxAddr.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAddr.Location = new System.Drawing.Point(167, 110);
            this.textBoxAddr.Name = "textBoxAddr";
            this.textBoxAddr.Size = new System.Drawing.Size(232, 44);
            this.textBoxAddr.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 37;
            this.label3.Text = "实习地址";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBoxLab
            // 
            this.richTextBoxLab.Location = new System.Drawing.Point(167, 180);
            this.richTextBoxLab.Name = "richTextBoxLab";
            this.richTextBoxLab.Size = new System.Drawing.Size(595, 366);
            this.richTextBoxLab.TabIndex = 36;
            this.richTextBoxLab.Text = "";
            // 
            // textBoxLabName
            // 
            this.textBoxLabName.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLabName.Location = new System.Drawing.Point(534, 40);
            this.textBoxLabName.Name = "textBoxLabName";
            this.textBoxLabName.Size = new System.Drawing.Size(232, 44);
            this.textBoxLabName.TabIndex = 35;
            // 
            // dateTimeLabTime
            // 
            this.dateTimeLabTime.Location = new System.Drawing.Point(538, 117);
            this.dateTimeLabTime.Name = "dateTimeLabTime";
            this.dateTimeLabTime.Size = new System.Drawing.Size(228, 28);
            this.dateTimeLabTime.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(401, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "实习时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(38, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 36);
            this.label8.TabIndex = 32;
            this.label8.Text = "实习内容";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(397, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 31;
            this.label6.Text = "报告名称";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStuName
            // 
            this.comboBoxStuName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStuName.FormattingEnabled = true;
            this.comboBoxStuName.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五"});
            this.comboBoxStuName.Location = new System.Drawing.Point(167, 46);
            this.comboBoxStuName.Name = "comboBoxStuName";
            this.comboBoxStuName.Size = new System.Drawing.Size(220, 36);
            this.comboBoxStuName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "选择学生";
            // 
            // EditStudentWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 659);
            this.Controls.Add(this.textBoxAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxLab);
            this.Controls.Add(this.textBoxLabName);
            this.Controls.Add(this.dateTimeLabTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxStuName);
            this.Controls.Add(this.label2);
            this.Name = "EditStudentWorkForm";
            this.Text = "修改实习报告";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxLab;
        private System.Windows.Forms.TextBox textBoxLabName;
        private System.Windows.Forms.DateTimePicker dateTimeLabTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStuName;
        private System.Windows.Forms.Label label2;
    }
}