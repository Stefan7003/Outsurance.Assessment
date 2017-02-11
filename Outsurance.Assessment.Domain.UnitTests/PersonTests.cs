using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Outsurance.Assessment.Domain.UnitTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Create_a_new_user()
        {
            Person person = Person.CreatePerson("Jimmy", "Smith", "102 Long Lane", "29384857");

            Assert.AreEqual(person.FirstName, "Jimmy");
            Assert.AreEqual(person.LastName, "Smith");
            Assert.AreEqual(person.Address, "102 Long Lane");
            Assert.AreEqual(person.PhoneNumber, "29384857");
        }
    }
}
