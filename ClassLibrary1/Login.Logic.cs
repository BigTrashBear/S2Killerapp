using System;
using System.Collections.Generic;
using System.Text;
using vanPiereApp.Models;



namespace vanPiereApp.Logic
{
    public class Login
    {
        public bool AuthorizeUser(string username, string password)
        {
            User user = new User(username, password, false); //hier eig user ophalen uit DB

            string _username = "Alex";
            string _password = "123";

            if (user == null)
            { return false; }
            else if (user.Get("username") == _username && user.Get("password") == _password) //opties voor geen user, password verkeerd en alles goed
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
