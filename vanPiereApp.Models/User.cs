using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace vanPiereApp.Models
{
    public class User
    {  
        private string username { get; set; }
        private string password { get; set; }
        private bool isloggedin { get; set; }

        public User(string _username, string _password, bool _isloggedin)
        {
            username = _username;
            password = _password;
            isloggedin = _isloggedin;
        }

        public string Get(string item)
        {
            if (item == "username")
            {
                return username;
            }
            else if (item == "password")
            {
                return password;
            }
            else { return null; }
        }

    }
}
