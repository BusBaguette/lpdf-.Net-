using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public int XpJoueur { get; set; }
        public int TempsJeu { get; set; }
        public float Pourcentage { get; set; }
        public int IdJeu { get; set; }
        public Jeu Jeu { get; set; }

        public Experience(int xpJoueur, int tempsJeu, float pourcentage, Jeu jeu)
        {
            XpJoueur = xpJoueur;
            TempsJeu = tempsJeu;
            Pourcentage = pourcentage;
            this.Jeu = jeu;
        }
        public Experience()
        {
        }
    }
}
