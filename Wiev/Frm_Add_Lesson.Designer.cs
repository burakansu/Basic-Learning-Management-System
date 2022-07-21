namespace OBS.Wiev
{
    partial class Frm_Add_Lesson
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
            this.TXT_Lesson_Name = new System.Windows.Forms.TextBox();
            this.Save_Lesson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Lesson_Name
            // 
            this.TXT_Lesson_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Lesson_Name.Location = new System.Drawing.Point(177, 15);
            this.TXT_Lesson_Name.Name = "TXT_Lesson_Name";
            this.TXT_Lesson_Name.Size = new System.Drawing.Size(321, 26);
            this.TXT_Lesson_Name.TabIndex = 9;
            this.TXT_Lesson_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Lesson_Name_KeyPress);
            // 
            // Save_Lesson
            // 
            this.Save_Lesson.BackColor = System.Drawing.Color.ForestGreen;
            this.Save_Lesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save_Lesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Lesson.Location = new System.Drawing.Point(0, 67);
            this.Save_Lesson.Name = "Save_Lesson";
            this.Save_Lesson.Size = new System.Drawing.Size(510, 34);
            this.Save_Lesson.TabIndex = 8;
            this.Save_Lesson.Text = "Kaydet";
            this.Save_Lesson.UseVisualStyleBackColor = false;
            this.Save_Lesson.Click += new System.EventHandler(this.Save_Lesson_Click);
            this.Save_Lesson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_Lesson_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ders Adı";
            // 
            // Frm_Add_Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 101);
            this.Controls.Add(this.TXT_Lesson_Name);
            this.Controls.Add(this.Save_Lesson);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Add_Lesson";
            this.Text = "Ders Ekle";
            this.Load += new System.EventHandler(this.Frm_Add_Lesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Lesson_Name;
        private System.Windows.Forms.Button Save_Lesson;
        private System.Windows.Forms.Label label1;
    }
}