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
    public class GestorDeBloque
    {

        public bool verificarCompleto(Bloque bloc)
        {
            try
            {
                bool completo = true;
                foreach (ItemBloque re in bloc.ItemBloque)
                {
                    if(re.id_respuesta == null)
                    {
                        completo = false;
                        break;
                    }
                }
                return completo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarBloque(Bloque bloque)
        {
            BloqueDAO cdatos = new BloqueDB();
            try
            {
                cdatos.modificarBloque(bloque);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarItemBloque(ItemBloque rtaEleg, int idRespuesta)
        {
            BloqueDAO cdatos = new BloqueDB();
            try
            {
                cdatos.modificarItemBloque(rtaEleg, idRespuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
