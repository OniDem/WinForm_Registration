using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
            
        }
    }
}
