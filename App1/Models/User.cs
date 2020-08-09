using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class User
    {
        public int id { get; set;  }
        public string Username { get; set; }
        public string Passsword { get; set; }

        public User()
        {

        }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Passsword = Password;
            System.Console.WriteLine("Username = " +this.Username);
        }

        public bool CheckInformation()
        {
            if (this.Username == null || this.Passsword == null) {
                return false;
            }
              System.Console.WriteLine("Username = " +this.Username);
            if (this.Username.ToString() != "" && this.Passsword.ToString() != "")
            return true;
            else
              return false;
            
        }
    }
}
