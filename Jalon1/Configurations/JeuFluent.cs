using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Jalon1.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jalon1.Configurations
{
    public class JeuFluent : EntityTypeConfiguration<Jeu>
    {
        public JeuFluent()
        {
            ToTable("Jeu");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("JEU_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("JEU_NOM").IsRequired().HasMaxLength(50);
            Property(c => c.Description).HasColumnName("JEU_DESCRIPTION").IsRequired().HasMaxLength(200);
            Property(c => c.Datedesortie).HasColumnName("JEU_DATEDESORTIE").IsRequired().HasMaxLength(50);
            Property(c => c.IdEditeur).HasColumnName("EXP_IDEDITEUR").IsRequired();
            Property(c => c.IdGenre).HasColumnName("EXP_IDGENRE").IsRequired();

            HasRequired(cc => cc.Editeur).WithMany().HasForeignKey(c => c.IdEditeur);
            HasRequired(cc => cc.Genre).WithMany().HasForeignKey(c => c.IdGenre);

        }
    }
}
