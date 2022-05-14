using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jalon1.Configurations
{
    public class EditeurFluent : EntityTypeConfiguration<Editeur>
    {
        public EditeurFluent()
        {
            ToTable("Editeur");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("EDITEUR_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("EDITEUR_NOM").IsRequired().HasMaxLength(50);
        }
    }
}
