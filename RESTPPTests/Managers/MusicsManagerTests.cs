using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTPP.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTPP.Models;

namespace RESTPP.Managers.Tests
{
    [TestClass()]
    public class MusicsManagerTests
    {
        private MusicsManager manager;

        [TestInitialize]
        public void Setup()
        {
            manager = new MusicsManager();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            IEnumerable<Music> musics = manager.GetAll("first");
            foreach (Music e in musics)
            {
                Assert.AreEqual(e.Title, "first");
            }
        }

        [TestMethod()]
        public void AddTest()
        {
            
            int defaultId = 0;

            Music music = new Music(defaultId, "kunstner", "sang", 1980);
            Music addResult = manager.Add(music);
            int newId = addResult.Id;

            Assert.AreNotEqual(defaultId, newId);
           
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}