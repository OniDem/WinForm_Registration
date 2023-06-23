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
    public partial class RegistrationForm : Form
    {
        Somethins somethins = new Somethins();

        private string _input_login;
        private string _input_password;
        public RegistrationForm()
        {
            InitializeComponent();
            somethins.UserName = _input_login;
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void Get_Login(object sender, EventArgs e)
        {
            _input_login = Login.Text;

        }

        private void Get_Password(object sender, EventArgs e)
        {
            _input_password = Password.Text;
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            



            //Close();
        }

        private void Auth_Button_Click(object sender, EventArgs e)
        {
            somethins.Users.Add(_input_login, _input_password);
            MessageBox.Show("Вы успешно авторизованны!");
            AuthorisedForm autorisedForm = new AuthorisedForm();
            autorisedForm.Show();
            Hide();
        }
    }
}
