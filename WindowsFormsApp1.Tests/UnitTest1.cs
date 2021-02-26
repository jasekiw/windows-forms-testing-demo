using System;
using NUnit.Framework;

namespace WindowsFormsApp1.Tests
{
    public class Tests
    {
        private MockDataService _mockDataService;
        private SomeData _someData;
        [SetUp]
        public void Setup()
        {
            _someData = new SomeData();
            _mockDataService = new MockDataService();
        }

        [Test]
        public void TestDataIsLoadedProperly()
        {
            _mockDataService.SetDataToReturn(_someData);
            var form1 = new Form1(_mockDataService);
            form1.LoadData();
            Assert.AreEqual(_someData, form1._loadedData);
        }
        
        [Test]
        public void TestButtonPressed()
        {
            var form1 = new Form1(_mockDataService);
            var args = new EventArgs();
            form1.button1_Click(null, args);
            Assert.AreEqual(false, form1.Visible);
        }
    }
}