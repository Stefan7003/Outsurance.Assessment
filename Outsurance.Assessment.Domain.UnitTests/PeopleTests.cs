using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;

namespace Outsurance.Assessment.Domain.UnitTests
{
    [TestClass]
    public class PeopleTests
    {
        [TestMethod]
        [ExpectedException(typeof(CSVFileReadingException))]
        public void PeopleCSVReader_Throw_FileNotFoundException()
        {
            People people = new People();
            var mock = new Mock<ICSVReader>();
            mock.Setup(CSVReader => CSVReader.ReadAllLines(It.IsAny<string>())).Throws(new FileNotFoundException());
            ICSVReader ICSVReaderMock = mock.Object;
            people.PeopleCSVReader(ICSVReaderMock, "InvalidFileName");
        }

        [TestMethod]
        [ExpectedException(typeof(CSVFileFormatException))]
        public void PeopleCSVReader_not_all_needed_arguments()
        {
            People people = new People();
            var mock = new Mock<ICSVReader>();
            mock.Setup(CSVReader => CSVReader.ReadAllLines(It.IsAny<string>())).Returns(new string[] { "firstName,lastName,adress,phonenumber", "firstName1,lastname1" });
            ICSVReader ICSVReaderMock = mock.Object;
            people.PeopleCSVReader(ICSVReaderMock, "InvalidFileName");
            Console.WriteLine(people.PeopleList);
        }

        [TestMethod]
        public void PeopleCSVReader_read_file()
        {
            People people = new People();
            CSVReader reader = new CSVReader();
            string filePath = System.IO.Path.GetFullPath(@"..\..\..\") + "CSV\\data.csv";
            people.PeopleCSVReader(reader, filePath);
        }

    }
}
