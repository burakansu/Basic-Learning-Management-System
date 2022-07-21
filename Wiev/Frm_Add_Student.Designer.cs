namespace OBS.Wiev
{
    partial class Frm_Add_Student
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
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.Save_Class = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Nick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Name
            // 
            this.TXT_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Name.Location = new System.Drawing.Point(197, 30);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(313, 26);
            this.TXT_Name.TabIndex = 9;
            this.TXT_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Name_KeyPress);
            // 
            // Save_Class
            // 
            this.Save_Class.BackColor = System.Drawing.Color.ForestGreen;
            this.Save_Class.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Class.Location = new System.Drawing.Point(0, 220);
            this.Save_Class.Name = "Save_Class";
            this.Save_Class.Size = new System.Drawing.Size(525, 34);
            this.Save_Class.TabIndex = 8;
            this.Save_Class.Text = "Kaydet";
            this.Save_Class.UseVisualStyleBackColor = false;
            this.Save_Class.Click += new System.EventHandler(this.Save_Class_Click);
            this.Save_Class.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_Class_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adı";
            // 
            // TXT_Surname
            // 
            this.TXT_Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Surname.Location = new System.Drawing.Point(197, 77);
            this.TXT_Surname.Name = "TXT_Surname";
            this.TXT_Surname.Size = new System.Drawing.Size(313, 26);
            this.TXT_Surname.TabIndex = 11;
            this.TXT_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Surname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyadı";
            // 
            // TXT_Password
            // 
            this.TXT_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Password.Location = new System.Drawing.Point(197, 170);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(313, 26);
            this.TXT_Password.TabIndex = 14;
            this.TXT_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Password_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Parola";
            // 
            // TXT_Nick
            // 
            this.TXT_Nick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Nick.Location = new System.Drawing.Point(197, 125);
            this.TXT_Nick.Name = "TXT_Nick";
            this.TXT_Nick.Size = new System.Drawing.Size(313, 26);
            this.TXT_Nick.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // Frm_Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 254);
            this.Controls.Add(this.TXT_Nick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_Surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.Save_Class);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Add_Student";
            this.Text = "Öğrenci Ekle";
            this.Load += new System.EventHandler(this.Frm_Add_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.Button Save_Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Nick;
        private System.Windows.Forms.Label label3;
    }
}