using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.ClasesDB;
using CEntidades;

namespace CDatos.ClasesDAO
{
    public interface PuestoDAO
    {
        void actualizarPuesto(int codigo, string nombre);
        Puesto obtenerPuesto(int codigoPuesto, string nombrePuesto);
        Puesto obtenerPuesto(int idPuesto);
        List<Puesto> obtenerPuesto();
        int obtenerUltimoIDPuesto(int codigo, string nombre);
        List<Puesto> getPuestos(Puesto pu);
        void alta(Puesto puesto);
    }
}
