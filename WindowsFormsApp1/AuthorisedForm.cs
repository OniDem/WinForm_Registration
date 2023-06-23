using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuthorisedForm : Form
    {
        private Somethins somethins = new Somethins();
        private string filePath = string.Empty;
        //private string _user_name;
        public AuthorisedForm()
        {
            InitializeComponent();
            
            label1.Text = "Добро пожаловать " + somethins.UserName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void Add_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(* .GIF)|*.GIF|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Picture1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void Picture1_Click(object sender, EventArgs e)
        {
            
        }


        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }
    }
}
