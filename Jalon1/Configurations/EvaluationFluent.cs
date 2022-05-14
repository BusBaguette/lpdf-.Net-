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

    class EvaluationFluent : EntityTypeConfiguration<Evaluation>
    {
        public EvaluationFluent()
        {
            ToTable("Evaluation");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("EVAL_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NomEvaluateur).HasColumnName("EVAL_NOMEVALUATEUR").IsRequired();
            Property(c => c.Date).HasColumnName("EVAL_DATE").IsRequired();
            Property(c => c.Note).HasColumnName("EVAL_NOTE").IsRequired();
            Property(c => c.IdJeu).HasColumnName("EVAL_IDJEU").IsRequired();


            HasRequired(cc => cc.Jeu).WithMany().HasForeignKey(c => c.IdJeu);
        }
    }
}
