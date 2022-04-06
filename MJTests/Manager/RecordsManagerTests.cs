using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestRecords.Manager;
using RestRecords.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestRecords.Models;
//using Stripe;

namespace RestRecords.Manager.Tests
{
    [TestClass()]
    public class RecordsManagerTests
    {

        private RecordsManager rm;
        private static int _nextId = 1;

        [TestInitialize]
        public void Setup()
        {
            rm = new RecordsManager();
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Assert.IsNotNull(rm.GetById(1));
            Assert.IsNull(rm.GetById(0));
        }

        [TestMethod()]
        public void GetAllRecordsTest()
        {
            List<Record> records = rm.GetAll();
            Assert.AreEqual(rm.GetAll().Count, 3);
            Assert.AreNotEqual(rm.GetAll().Count, 4);
        }

        [TestMethod()]
        public void AddTest()
        {
            Record newRec = new Record("Granit", _nextId++, "sten");

        }

        [TestMethod()]
        public void DeleteTest()
        {
            Record newRec = new Record("Granit", _nextId++, "sten");
            Record addResult = rm.Add(newRec);
            int NewId = addResult.Id;
            Record deletedRecord = rm.Delete(NewId);

            //her tester vi om man kan delete på id 10 som gerne skulle give en fejl
            Assert.IsNull(rm.Delete(10));

        }



        [TestMethod]
        public void UpdateTest()
        {
            Record newRec = new Record("Granit", 20, "sten");
            rm.Add(newRec);
            Record id2 = new Record("updatemig", 82, "upd");

            Record test = rm.Update(4, id2);

            Assert.AreEqual("upd", test.ArtistName);

        }

    }
}