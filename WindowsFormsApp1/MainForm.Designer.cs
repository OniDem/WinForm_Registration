namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.Info;
            this.Register.Location = new System.Drawing.Point(102, 164);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(166, 52);
            this.Register.TabIndex = 1;
            this.Register.Text = "Зарегестироваться";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Auth
            // 
            this.Auth.BackColor = System.Drawing.Color.LightCoral;
            this.Auth.Location = new System.Drawing.Point(535, 164);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(166, 52);
            this.Auth.TabIndex = 2;
            this.Auth.Text = "Войти";
            this.Auth.UseVisualStyleBackColor = false;
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Auth);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Добро пожаловать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Auth;
    }
}