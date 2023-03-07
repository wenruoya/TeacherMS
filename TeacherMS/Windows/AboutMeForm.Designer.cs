namespace TeacherMS.Windows
{
    partial class AboutMeForm
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
            this.buttonSure = new System.Windows.Forms.Button();
            this.richTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonSure
            // 
            this.buttonSure.Location = new System.Drawing.Point(513, 374);
            this.buttonSure.Name = "buttonSure";
            this.buttonSure.Size = new System.Drawing.Size(225, 50);
            this.buttonSure.TabIndex = 3;
            this.buttonSure.Text = "确认";
            this.buttonSure.UseVisualStyleBackColor = true;
            this.buttonSure.Click += new System.EventHandler(this.buttonSure_Click);
            // 
            // richTextBoxAbout
            // 
            this.richTextBoxAbout.Location = new System.Drawing.Point(32, 27);
            this.richTextBoxAbout.Name = "richTextBoxAbout";
            this.richTextBoxAbout.Size = new System.Drawing.Size(736, 326);
            this.richTextBoxAbout.TabIndex = 2;
            this.richTextBoxAbout.Text = "一个练习项目罢了";
            // 
            // AboutMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSure);
            this.Controls.Add(this.richTextBoxAbout);
            this.Name = "AboutMeForm";
            this.Text = "AboutMeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSure;
        private System.Windows.Forms.RichTextBox richTextBoxAbout;
    }
}