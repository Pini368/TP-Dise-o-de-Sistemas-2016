using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDB;
using CDatos.ClasesDAO;

namespace CLogica.Gestores
{
    public class GestorDeAutenticacion
    {
        public static Candidato candActual;
        public static Consultor consActual;

        public static void autenticarUsuario(Candidato cand)
        {
            candActual = cand;
        }

        public static void autenticarUsuario(Consultor cons, string contra)
        {
            try
            {
                LDAPDAO ldap = new LDAPDB();
                if(ldap.obtenerConsultor(cons, contra))
                {
                    consActual = cons;
                }
                else
                {
                    throw new ExceptionPersonalizada("El usuario o contraseña no corresponde a ningun consultor registrado en el sistema.");
                }
            }
            catch (Exception ex){
                throw new ExceptionPersonalizada(ex.Message);
            }
        }

        public static Consultor obtenerConsultorActual()
        {
            return consActual;
        }

        public static Candidato obtenerCandidatoActual()
        {
            return candActual;
        }
    }
}
