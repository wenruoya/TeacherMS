namespace TeacherMS.Windows
{
    partial class EditTeachPlanForm
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
            this.richTextBoxCent = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTeacherName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlanName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxCent
            // 
            this.richTextBoxCent.Location = new System.Drawing.Point(173, 192);
            this.richTextBoxCent.Name = "richTextBoxCent";
            this.richTextBoxCent.Size = new System.Drawing.Size(594, 323);
            this.richTextBoxCent.TabIndex = 26;
            this.richTextBoxCent.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(27, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 25;
            this.label7.Text = "教案内容";
            // 
            // comboBoxTeacherName
            // 
            this.comboBoxTeacherName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxTeacherName.FormattingEnabled = true;
            this.comboBoxTeacherName.Items.AddRange(new object[] {
            "一",
            "二",
            "三",
            "四",
            "五",
            "六",
            "七"});
            this.comboBoxTeacherName.Location = new System.Drawing.Point(173, 86);
            this.comboBoxTeacherName.Name = "comboBoxTeacherName";
            this.comboBoxTeacherName.Size = new System.Drawing.Size(232, 36);
            this.comboBoxTeacherName.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboBoxSubject.Location = new System.Drawing.Point(173, 36);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(232, 36);
            this.comboBoxSubject.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 23;
            this.label5.Text = "所属老师";
            // 
            // textBoxPlanName
            // 
            this.textBoxPlanName.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPlanName.Location = new System.Drawing.Point(535, 64);
            this.textBoxPlanName.Name = "textBoxPlanName";
            this.textBoxPlanName.Size = new System.Drawing.Size(232, 44);
            this.textBoxPlanName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "所属课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(411, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "教案名称";
            // 
            // EditTeachPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 633);
            this.Controls.Add(this.richTextBoxCent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTeacherName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPlanName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditTeachPlanForm";
            this.Text = "修改教案";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTeacherName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlanName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}