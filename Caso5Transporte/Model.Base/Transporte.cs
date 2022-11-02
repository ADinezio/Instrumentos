using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso5Transporte.Model.Base
{
    public abstract class Transporte
    {

        #region constructores
        public Transporte(int maxFuel, int maxNroDePasajeros, int velocidad)
        {
            _MaxFuel = maxFuel;
            _MaxNroDePasajeros = maxNroDePasajeros;
            _Velocidad = velocidad;

        }
        #endregion

        #region propiedades
        private int _MaxFuel;
        private int _MaxNroDePasajeros;
        private int _Velocidad;
        #endregion

        #region metodos
        public virtual string Acelerar() => "Acelerando";
        public virtual string Desacelerar() => "Desacelerando";

        public int MaxFuel { get => _MaxFuel;}
        public int MaxNroDePasajeros { get => _MaxNroDePasajeros;}
        public int Velocidad { get => _Velocidad;}

        #endregion

    }
}
