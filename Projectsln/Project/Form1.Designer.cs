namespace Project
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.Admin2 = new System.Windows.Forms.Button();
            this.Manager2 = new System.Windows.Forms.Button();
            this.Admin1 = new System.Windows.Forms.Button();
            this.Manager1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(224, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to T Agency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.OrangeRed;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(263, 132);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(173, 63);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.OrangeRed;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(263, 261);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(173, 63);
            this.Registration.TabIndex = 2;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Admin2
            // 
            this.Admin2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Admin2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin2.Location = new System.Drawing.Point(207, 330);
            this.Admin2.Name = "Admin2";
            this.Admin2.Size = new System.Drawing.Size(143, 47);
            this.Admin2.TabIndex = 3;
            this.Admin2.Text = "Admin";
            this.Admin2.UseVisualStyleBackColor = false;
            this.Admin2.Visible = false;
            this.Admin2.Click += new System.EventHandler(this.Admin2_Click);
            // 
            // Manager2
            // 
            this.Manager2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Manager2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manager2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manager2.Location = new System.Drawing.Point(356, 330);
            this.Manager2.Name = "Manager2";
            this.Manager2.Size = new System.Drawing.Size(143, 46);
            this.Manager2.TabIndex = 4;
            this.Manager2.Text = "Manager";
            this.Manager2.UseVisualStyleBackColor = false;
            this.Manager2.Visible = false;
            this.Manager2.Click += new System.EventHandler(this.Manager2_Click);
            // 
            // Admin1
            // 
            this.Admin1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Admin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin1.Location = new System.Drawing.Point(207, 201);
            this.Admin1.Name = "Admin1";
            this.Admin1.Size = new System.Drawing.Size(143, 46);
            this.Admin1.TabIndex = 5;
            this.Admin1.Text = "Admin";
            this.Admin1.UseVisualStyleBackColor = false;
            this.Admin1.Visible = false;
            this.Admin1.Click += new System.EventHandler(this.Admin1_Click);
            // 
            // Manager1
            // 
            this.Manager1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Manager1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manager1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manager1.Location = new System.Drawing.Point(356, 201);
            this.Manager1.Name = "Manager1";
            this.Manager1.Size = new System.Drawing.Size(143, 46);
            this.Manager1.TabIndex = 6;
            this.Manager1.Text = "Manager";
            this.Manager1.UseVisualStyleBackColor = false;
            this.Manager1.Visible = false;
            this.Manager1.Click += new System.EventHandler(this.Manager1_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(12, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(64, 30);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Manager1);
            this.Controls.Add(this.Admin1);
            this.Controls.Add(this.Manager2);
            this.Controls.Add(this.Admin2);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Text = "T Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Admin2;
        private System.Windows.Forms.Button Manager2;
        private System.Windows.Forms.Button Admin1;
        private System.Windows.Forms.Button Manager1;
        private System.Windows.Forms.Button refresh;
    }
}

