using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos
{
    public class CandidatoMap : EntityTypeConfiguration<Candidato>
    {
        public CandidatoMap()
        {
            HasKey(x => x.nroCandidato);
            Property(x => x.nombre).HasMaxLength(30).IsRequired();
            Property(x => x.apellido).HasMaxLength(30).IsRequired();

            Property(x => x.email).HasMaxLength(50);
        }
    }
}
