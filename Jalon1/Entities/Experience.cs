using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Experience
    {
         /// <summary>
        /// Identifiant de l'expérience
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Experience du joueur
        /// </summary>
        public int XpJoueur { get; set; }

        /// <summary>
        /// Temps de jeu du joueur
        /// </summary>
        public int TempsJeu { get; set; }

        /// <summary>
        /// Pourcentage de complétion du jeu
        /// </summary>
        public float Pourcentage { get; set; }

        /// <summary>
        /// Identifiant du jeu associé à l'expérience
        ///
        public int IdJeu { get; set; }

        /// <summary>
        /// Jeu associé à l'expérience
        /// Le framework va automatiquement charger cet objet
        /// </summary>
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
