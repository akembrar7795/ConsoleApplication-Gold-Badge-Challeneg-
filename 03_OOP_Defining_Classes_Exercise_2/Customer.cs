using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_2
{
    public class Customer
    {
        //properties
        private string  _firstName;

        public string  FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a customer firstname");

                _firstName = value;
            }
        }

        private string _lastName;

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("You must enter a customer lastname");

                _lastName = value;
            }
        }









        private int _iDNumber;

        public int IDNumber
        {
            get
            {
                return _iDNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Customer ID can not be a negative or zero.");
                }


                _iDNumber = value;
            }
        }

        private int _numberOfYearsUsingTomado;

        public int NumberOfYearsUsingTomado
        {
            get
            {
                return _numberOfYearsUsingTomado;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Year can not be a negative. ");
                }
                _numberOfYearsUsingTomado = value;
            }
        }


        //constructor
        public Customer(string firstname, string lastname, int idnumber, int numberofyearsusingtomado)
        {
            FirstName = firstname;
            LastName = lastname;
            IDNumber = idnumber;
            NumberOfYearsUsingTomado = numberofyearsusingtomado;
        }

        // method
        public string SendCustomerMessage()
        {
            string message = "default Message";

            if(NumberOfYearsUsingTomado >= 1 && NumberOfYearsUsingTomado < 5)
            {
                message = "Thanks for being a member";
                return message;
            }

            if (NumberOfYearsUsingTomado >= 5)
            {
               message =  "Thank you for being a Gold Member";
                return message;
            }
            
            return message;
        }
        

    }
    
    
    
}
