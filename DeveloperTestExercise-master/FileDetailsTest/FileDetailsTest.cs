using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThirdPartyTools;

namespace FileDetailsTest
{
    [TestClass]
    public class FileDetailsTest
    {
        [TestMethod]
        public void TEST_VERSION_POSITIVE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.IsNotNull(fileDetails.Version(), "File Version is null.");
            Assert.IsTrue(Regex.IsMatch(fileDetails.Version(), @"^(\d+\.){3}(\d+)$"), "Incorrect Version Number.");
        }

        [TestMethod]
        public void TEST_SIZE_POSITIVE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.AreNotEqual(fileDetails.Size(), 0, "File Size is zero bytes.");
        }

        [TestMethod]
        public void TEST_CREATE_DATE_POSITIVE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.IsNotNull(fileDetails.CreateDate(), "Create Date is null.");
        }

        [TestMethod]
        public void TEST_CREATE_DATE_NEGATIVE_MINVALUE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.AreNotEqual(DateTime.MinValue, fileDetails.CreateDate(), "Test case failed.");
        }

        [TestMethod]
        public void TEST_VERSION_NEGATIVE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.IsNull(fileDetails.Version());
            Assert.AreNotEqual("0.1.23", fileDetails.Version(), "Test case failed.");
        }

        [TestMethod]
        public void TEST_SIZE_NEGATIVE()
        {
            FileDetails fileDetails = new FileDetails(@"C:\Test.txt");
            Assert.IsNull(fileDetails.Size());
        }

    }
}
