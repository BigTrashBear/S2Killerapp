using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace S2Killerapp.Models
{
    class User
    {
        private string Username;
        private string Password;
        Swapbox swapbox;

        public User(string _username, string _password)
        {
            Username = _username;
            Password = _password;

            swapbox = new Swapbox(Username);
        }
    }
}