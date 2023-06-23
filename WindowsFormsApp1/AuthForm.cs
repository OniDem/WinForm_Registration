using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class AuthForm : Form
    {
        Somethins somethins = new Somethins();
             
        private string _input_login;
        private string _input_password;
        private bool _authorised = false;
        public AuthForm()
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
            
            foreach (var auth in somethins.Users)
            {
                if (auth.Key == _input_login && auth.Value == _input_password)
                {
                    MessageBox.Show("Вы успешно авторизованны!"); 
                    _authorised = true;
                    AuthorisedForm autorisedForm = new AuthorisedForm();
                    
                    autorisedForm.Show();
                    this.Dispose();
                    break;
                }
            }
            if (_authorised == false)
            {
                MessageBox.Show("Вы ввели некорректные данные!");
            }
            
            //Close();
        }
    }
}
