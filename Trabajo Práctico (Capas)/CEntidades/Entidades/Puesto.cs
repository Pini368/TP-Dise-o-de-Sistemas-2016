using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Puesto
    {
        private int _codigo;
        private string _nombre;
        private string _descripcion;
        private string _empresa;
        private List<Caracteristica> _caracteristicas;

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

        public string Empresa
        {
            get
            {
                return _empresa;
            }

            set
            {
                _empresa = value;
            }
        }

        public List<Caracteristica> Caracteristicas
        {
            get
            {
                return _caracteristicas;
            }

            set
            {
                _caracteristicas = value;
            }
        }

        public Puesto(int cod, string nom, string desc, string emp, List<Caracteristica> lc)
        {
            _codigo = cod;
            _nombre = nom;
            _descripcion = desc;
            _empresa = emp;
            _caracteristicas = lc;
        }

        public Puesto(int cod, string nom, string desc, string emp)
        {
            _codigo = cod;
            _nombre = nom;
            _descripcion = desc;
            _empresa = emp;
            _caracteristicas = new List<Caracteristica>();
        }
    }
}
