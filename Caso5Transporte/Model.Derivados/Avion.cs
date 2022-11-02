using Caso5Transporte.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso5Transporte.Model.Derivados
{
    public class Avion:Transporte
    {
        #region constructores
        public Avion(int maxAltitud,int nroMotores,int maxFuel, int maxNroDePasajeros, int velocidad) : base(maxFuel, maxNroDePasajeros, velocidad)
        {
            _MaxAltitud = maxAltitud;
            _NroMotores = nroMotores;
        }
        #endregion

        #region propiedades
        private int _MaxAltitud;
        private int _NroMotores;
        #endregion

        #region metodos
        public int MaxAltitud { get => _MaxAltitud;}
        public int NroMotores { get => _NroMotores;}

        public string Descender() => "El avion esta descendiendo";
        public string Ascender() => "El avion esta ascendiendo";
        #endregion

    }
}
