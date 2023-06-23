using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Somethins
    {
        private string _user_name;
        private Dictionary<string, string> _users = new Dictionary<string, string>()
        {
            {"OniDem1", "Strong_Password" },
            {"Endliar", "Weak_Password" }
        };

        public Dictionary<string, string> Users
        {
            get { return _users; }
            set { _users = value; }
        }
        public string UserName
        {
            get
            {
                return _user_name; 
            }
            set 
            {
                _user_name = value; 
            }
        }
    }
}
