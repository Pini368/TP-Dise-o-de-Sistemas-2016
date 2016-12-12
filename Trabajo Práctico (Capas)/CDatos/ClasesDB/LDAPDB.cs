using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.ClasesDAO;
using CEntidades;

namespace CDatos.ClasesDB
{
    public class LDAPDB : LDAPDAO
    {
        public bool obtenerConsultor(Consultor cons, string contra)
        {
            using (TPDiseñoEntities db = new TPDiseñoEntities())
            {
                return (db.LDAP.Where(ldap => ldap.nombreUsuario.ToUpper() == cons.nombreUsuario && ldap.contraseña == contra).Count() == 1);
            }
        }
    }
}
