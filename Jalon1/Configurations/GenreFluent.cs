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
    public class GenreFluent : EntityTypeConfiguration<Genre>
    {
        public GenreFluent()
        {
            ToTable("Genre");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("GENRE_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("GENRE_NOM").IsRequired().HasMaxLength(50);
        }

    }
}
