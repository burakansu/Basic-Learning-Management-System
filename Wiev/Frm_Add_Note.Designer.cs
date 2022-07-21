namespace OBS.Wiev
{
    partial class Frm_Add_Note
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
            this.TXT_Note = new System.Windows.Forms.TextBox();
            this.Save_Class = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Note
            // 
            this.TXT_Note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Note.Location = new System.Drawing.Point(177, 8);
            this.TXT_Note.Name = "TXT_Note";
            this.TXT_Note.Size = new System.Drawing.Size(168, 26);
            this.TXT_Note.TabIndex = 26;
            this.TXT_Note.TextChanged += new System.EventHandler(this.TXT_Note_TextChanged);
            this.TXT_Note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Note_KeyPress);
            // 
            // Save_Class
            // 
            this.Save_Class.BackColor = System.Drawing.Color.ForestGreen;
            this.Save_Class.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Save_Class.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Class.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_Class.Location = new System.Drawing.Point(0, 49);
            this.Save_Class.Name = "Save_Class";
            this.Save_Class.Size = new System.Drawing.Size(355, 34);
            this.Save_Class.TabIndex = 25;
            this.Save_Class.Text = "Kaydet";
            this.Save_Class.UseVisualStyleBackColor = false;
            this.Save_Class.Click += new System.EventHandler(this.Save_Class_Click);
            this.Save_Class.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Save_Class_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Not";
            // 
            // Frm_Add_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 83);
            this.Controls.Add(this.TXT_Note);
            this.Controls.Add(this.Save_Class);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Frm_Add_Note";
            this.Text = "Not Girişi";
            this.Load += new System.EventHandler(this.Frm_Add_Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Note;
        private System.Windows.Forms.Button Save_Class;
        private System.Windows.Forms.Label label1;
    }
}