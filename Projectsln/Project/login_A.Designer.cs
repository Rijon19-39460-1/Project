﻿namespace Project
{
    partial class LAdmin
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
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(151, 151);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(267, 27);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(151, 108);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(267, 27);
            this.username.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(48, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Password:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Username:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(183, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(183, 271);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(127, 46);
            this.Back.TabIndex = 8;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(145, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login as Admin";
            // 
            // ck1
            // 
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(151, 183);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(128, 21);
            this.ck1.TabIndex = 19;
            this.ck1.Text = "Show password";
            this.ck1.UseVisualStyleBackColor = true;
            this.ck1.CheckedChanged += new System.EventHandler(this.ck1_CheckedChanged);
            // 
            // LAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 379);
            this.Controls.Add(this.ck1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LAdmin";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ck1;
    }
}