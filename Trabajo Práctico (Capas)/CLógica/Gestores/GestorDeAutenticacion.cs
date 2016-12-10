using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using CDatos.ClasesDAO;
using CDatos.ClasesDB;
using System.Linq.Expressions;


namespace CLogica.Gestores
{
    
    public class GestorDeAutenticacion
    {
        public bool exito;
        public static Candidato candActual;
        public static Consultor consActual;

        public static void setCandidatoActual(Candidato cand)
        {
            candActual = cand;
        }

        public static bool autenticarUsuario(Candidato cand)
        {
            bool exito;
            try
            {
                CandidatoDAO cdatosC = new CandidatoDB();
                Expression<Func<Candidato, bool>> filtro = (ca => ca.nro_documento == cand.nro_documento && ca.tipo_documento == cand.tipo_documento);
                List<Candidato> lc = cdatosC.getCandidatos(filtro);
                if (lc.Count() == 1)
                {
                    if (lc.First().contraseña == cand.contraseña)
                    {
                        candActual = lc.First();
                        GestorDeCuestionario clogCuest = new GestorDeCuestionario();
                        exito = clogCuest.verificarCuestionariosActivos(obtenerCandidatoActual());
                        return exito;
                    }
                    else
                    {
                        exito = false;
                        return exito;
                    }
                }
                else
                {
                    exito = false;
                    return exito;
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionPersonalizada(ex.Message);
            }

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
