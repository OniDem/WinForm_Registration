namespace WindowsFormsApp1
{
    partial class AuthForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Авторизоваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Auth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Для авторизации введите логин и пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(269, 233);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(199, 20);
            this.Password.TabIndex = 3;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.Get_Password);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(269, 181);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(199, 20);
            this.Login.TabIndex = 4;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.TextChanged += new System.EventHandler(this.Get_Login);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(352, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}