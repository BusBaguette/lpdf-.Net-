using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jalon1.Entities;
using Jalon1;
using BusinessLayer;

namespace Modele.Console.LPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = Manager.Instance;
            manager.AjouterJeu(new Jeu("LOL", "NuL jeu", "19/07/2008", 1, 2));
            List<Editeur> editeurs = manager.GetAllEditeur();
            System.Console.WriteLine("---- LISTE DES EDITEURS -----");
            foreach (Editeur e in editeurs)
            {
                System.Console.WriteLine("Editeur ID {0} : {1}", e.Id, e.Nom);
            }
            System.Console.ReadLine();
        }
    }
}
