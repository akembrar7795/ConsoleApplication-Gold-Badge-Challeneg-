using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Gold_Badge_Challenge_04
{
    class Email
    {
        public Email( string firstname, string lastname, string type, string sendemail)
        {
            FirstName = firstname;
            LastName = lastname;
            Type = type;
            SendEmail = sendemail;

        }
            

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string SendEmail { get; set; }

    }

}
