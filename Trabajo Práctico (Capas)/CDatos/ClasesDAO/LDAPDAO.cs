using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface LDAPDAO
    {
        bool obtenerConsultor(Consultor cons, string contra);
    }
}
