using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Competencia
    {
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private string _estado;

        public int Codigo
        {
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public string Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

        public Competencia(int cod, string nom, string desc, string est)
        {
            _codigo = cod;
            _nombre = nom;
            _descripcion = desc;
            _estado = est;
        }

        public bool Igual(Competencia comp)
        {
            return (_codigo == comp.Codigo && _nombre == comp.Nombre && _descripcion == comp.Descripcion && _estado == comp.Estado);
        }
    }
}
