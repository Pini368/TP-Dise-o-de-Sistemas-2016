using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.ClasesDB;
using CEntidades;
using System.Linq.Expressions;

namespace CDatos.ClasesDAO
{
    public interface PuestoDAO
    {
        /*
        Puesto obtenerPuesto(int codigoPuesto, string nombrePuesto);
        Puesto obtenerPuesto(int idPuesto);
        List<Puesto> obtenerPuesto();
        */
        int obtenerUltimoIDPuesto(int codigo, string nombre);
        List<Puesto> getPuestos(Expression<Func<Puesto, bool>> filtro);
        void alta(Puesto puesto);
        void baja(Puesto puesto, Consultor consultorActual);
        void modificar(Puesto puesto);
    }
}
