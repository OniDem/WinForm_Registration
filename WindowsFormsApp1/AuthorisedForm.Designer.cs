namespace WindowsFormsApp1
{
    partial class AuthorisedForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorisedForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Add_Picture = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Picture1
            // 
            this.Picture1.Location = new System.Drawing.Point(544, 0);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(230, 268);
            this.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Picture1.TabIndex = 1;
            this.Picture1.TabStop = false;
            this.Picture1.Click += new System.EventHandler(this.Picture1_Click);
            // 
            // Add_Picture
            // 
            this.Add_Picture.Location = new System.Drawing.Point(544, 415);
            this.Add_Picture.Name = "Add_Picture";
            this.Add_Picture.Size = new System.Drawing.Size(155, 23);
            this.Add_Picture.TabIndex = 2;
            this.Add_Picture.Text = "Добавить картинку";
            this.Add_Picture.UseVisualStyleBackColor = true;
            this.Add_Picture.Click += new System.EventHandler(this.Add_Picture_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // AuthorisedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_Picture);
            this.Controls.Add(this.Picture1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumPurple;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorisedForm";
            this.Text = "Добро пожаловать";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.Button Add_Picture;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

