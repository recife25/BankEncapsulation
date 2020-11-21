//Felipe Ruiz 
//using System is called using directive
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulation
{
    //class PersonalInformation with default constructor 
    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        //create a field or a var in a class
        private string phoneNumber;

        public string NumberFormatted 
        {
            get 
            {
                return phoneNumber; 
            }
            set 
            {
                //regex.replace is a method 
                phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "($1)-$2-$3");


            }

        }


       
    }
}
