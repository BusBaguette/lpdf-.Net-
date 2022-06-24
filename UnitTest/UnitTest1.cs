using BusinessLayer;
using Jalon1.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestAddGenre()
        {
            Genre g = new Genre("wow");
            Assert.IsTrue(Manager.Instance.AjouterGenre(g) > 0);
        }

        [TestMethod]
        public void TestEditGenre()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            g.Nom = "arret";
            Manager.Instance.ModifierGenre(g);

            Assert.IsTrue(Manager.Instance.GetGenreById(g.Id).Nom == "arret");

        }

        [TestMethod]
        public void TestDeleteGenre()
        {
            Genre g = new Genre("toto");
            Manager.Instance.AjouterGenre(g);
            Manager.Instance.SupprimerGenre(g.Id);

            Assert.IsTrue(Manager.Instance.GetAllGenre().Count(genre => genre.Nom == "toto") == 0);
        }

        [TestMethod]
        public void TestGetAllGenre()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            Assert.IsTrue(Manager.Instance.GetAllGenre().Count > 0);
        }

        [TestMethod]
        public void TestGetGenreById()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            Assert.IsTrue(Manager.Instance.GetGenreById(g.Id) == g);
        }
    }
}
