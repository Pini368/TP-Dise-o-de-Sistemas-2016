using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Caracteristica
    {
        private Competencia _competencia;
        private int _ponderacion;

        public Competencia Competencia
        {
            get
            {
                return _competencia;
            }

            set
            {
                _competencia = value;
            }
        }

        public int Ponderacion
        {
            get
            {
                return _ponderacion;
            }

            set
            {
                _ponderacion = value;
            }
        }
        public Caracteristica(Competencia comp, int pond)
        {
            _competencia = comp;
            _ponderacion = pond;
        }

        public Caracteristica() { }

        public bool Igual(Caracteristica car)
        {
            return (_competencia.Igual(car.Competencia) && _ponderacion == car.Ponderacion);
        }
    }
}
