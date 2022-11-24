using System.Diagnostics;

namespace AddressBookApp
{ 
    public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public double phoneNo { get; set; }
            public string emailId { get; set; }

        public Person(string firstName, string lastName, string address, double phoneNo, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }
        public Person()
        {

        }
    }
    }

