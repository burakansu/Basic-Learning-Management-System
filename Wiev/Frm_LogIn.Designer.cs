namespace OBS
{
    partial class Frm_LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_No = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.BTN_Enter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // TXT_No
            // 
            this.TXT_No.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_No.Location = new System.Drawing.Point(209, 161);
            this.TXT_No.Name = "TXT_No";
            this.TXT_No.Size = new System.Drawing.Size(213, 26);
            this.TXT_No.TabIndex = 2;
            this.TXT_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_No_KeyPress);
            // 
            // TXT_Password
            // 
            this.TXT_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Password.Location = new System.Drawing.Point(209, 210);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(213, 26);
            this.TXT_Password.TabIndex = 3;
            this.TXT_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_Password_KeyDown);
            this.TXT_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_No_KeyPress);
            // 
            // BTN_Enter
            // 
            this.BTN_Enter.BackColor = System.Drawing.Color.ForestGreen;
            this.BTN_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Enter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Enter.Location = new System.Drawing.Point(0, 329);
            this.BTN_Enter.Name = "BTN_Enter";
            this.BTN_Enter.Size = new System.Drawing.Size(449, 34);
            this.BTN_Enter.TabIndex = 4;
            this.BTN_Enter.Text = "Giriş";
            this.BTN_Enter.UseVisualStyleBackColor = false;
            this.BTN_Enter.Click += new System.EventHandler(this.BTN_Enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Yönetim Ve Bilgi Sistemi";
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Exit.BackgroundImage")));
            this.BTN_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Exit.Location = new System.Drawing.Point(408, 7);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(30, 30);
            this.BTN_Exit.TabIndex = 6;
            this.BTN_Exit.TabStop = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            this.BTN_Exit.MouseEnter += new System.EventHandler(this.BTN_Exit_MouseEnter);
            this.BTN_Exit.MouseLeave += new System.EventHandler(this.BTN_Exit_MouseLeave);
            // 
            // Frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(449, 363);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Enter);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.TXT_No);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_LogIn_FormClosing);
            this.Load += new System.EventHandler(this.Frm_LogIn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_LogIn_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_No;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Button BTN_Enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BTN_Exit;
    }
}

