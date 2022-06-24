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
        public void TestAjoutGenre()
        {
            Genre g = new Genre("wow");
            var a = Manager.Instance.AjouterGenre(g);
            Manager.Instance.SupprimerGenre(1);
            Assert.IsTrue(a > 0);
        }

        [TestMethod]
        public void TestEditGenre()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            g.Nom = "arret";
            Manager.Instance.ModifierGenre(g);
            var a = Manager.Instance.GetGenreById(g.Id).Nom;
            Manager.Instance.SupprimerGenre(1);

            Assert.IsTrue(a == "arret");

        }

        [TestMethod]
        public void TestDeleteGenre()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            Manager.Instance.SupprimerGenre(g.Id);

            Assert.IsTrue(Manager.Instance.GetAllGenre().Count(genre => genre.Nom == "wow") == 0);
        }

        [TestMethod]
        public void TestGetAllGenre()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            var a = Manager.Instance.GetAllGenre().Count;
            Manager.Instance.SupprimerGenre(1);
            Assert.IsTrue(a > 0);
        }

        [TestMethod]
        public void TestGetGenreById()
        {
            Genre g = new Genre("wow");
            Manager.Instance.AjouterGenre(g);
            var a = Manager.Instance.GetGenreById(g.Id);
            Manager.Instance.SupprimerGenre(1);
            Assert.IsTrue(a == g);
        }
    }
}
