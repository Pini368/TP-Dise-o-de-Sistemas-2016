using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using System.Data.Entity.ModelConfiguration;

namespace CDatos
{
    public class EvaluacionMap : EntityTypeConfiguration<Evaluacion>
    {
        public EvaluacionMap()
        {
            HasKey(x => x.id_evaluacion);
            Property(x => x.id_puesto).HasColumnType("int").IsRequired();

            HasMany(x => x.Candidato)
                .WithMany(x => x.Evaluacion)
                .Map(mc =>
                {
                    mc.MapLeftKey("id_evaluacion");
                    mc.MapRightKey("nroCandidato");
                    mc.ToTable("EvaluacionCandidato");
                });
        }
    }
}
