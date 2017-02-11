using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outsurance.Assessment.Domain
{
    public class Person
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }

        public string Address { get; protected set; }
        public string PhoneNumber { get; protected set; }

        public static Person CreatePerson(string firstName, string lastName, string address, string phoneNumber)
        {
            Person person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                PhoneNumber = phoneNumber
            };

            return person;
        }

    }
}
