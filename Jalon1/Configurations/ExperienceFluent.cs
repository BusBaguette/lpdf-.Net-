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
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("Experience");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("EXP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.XpJoueur).HasColumnName("EXP_XPJOUEUR").IsRequired();
            Property(c => c.TempsJeu).HasColumnName("EXP_TEMPSDEJEU").IsRequired();
            Property(c => c.Pourcentage).HasColumnName("EXP_POURCENTAGE").IsRequired();
            Property(c => c.IdJeu).HasColumnName("EXP_IDJEU").IsRequired();


            HasRequired(cc => cc.Jeu).WithMany().HasForeignKey(c => c.IdJeu);
        }
    }
}
