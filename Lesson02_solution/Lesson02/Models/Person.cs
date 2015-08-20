using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson02.Models {
    public class Person {

        // fields 
        private string zip;
        private string email;
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthday;


        // Auto-implemented properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }


        // All property names are capitalised
        public string Zip {
            set { zip = value; }
            get { return zip; }
        }
        
        public string Email {
            set { email = value; }
            get { return email; }
        }

        // read only property
        public List<string> PhoneNumbers {
            get { return phoneNumbers; }
        }

        // property that validates input (the set accessor)
        public DateTime Birthday {
            set {
                if ((DateTime.Now.Year - value.Year) > 120 ||
                    (DateTime.Now.Year - value.Year) < 0) {
                    throw new Exception("Age is not accepted");
                }
                else {
                    birthday = value;
                }
            }
            get { return birthday; }
        }

        // read only property
        public int Age {
            get {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthday.Year;
                if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day)) {
                    age--;
                }
                return age;
            }
        }

        // constructor 1
        public Person(String firstname, String lastname) {
            Firstname = firstname;
            Lastname = lastname;
        }

        // constructor 2
        public Person(string firstname, string lastname, string address, string zip, string city) {
            Firstname = firstname;
            Lastname = lastname;
            Adress = address;
            this.zip = zip;
            City = city;
        }


        // method
        public void AddPhone(string phone) {
            phoneNumbers.Add(phone);
        }
    }
}