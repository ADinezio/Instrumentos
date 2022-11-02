using LibreriaAjedrez.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Model.Derivadas
{
    public class Torre:PiezaAjedrez
    {
        #region constructor
        public Torre(string nombrePieza): base(nombrePieza) { }
        #endregion

        #region metodos
        public override string Mover(string movimiento) => $"Pieza : {NombrePieza}\nMovimiento : {movimiento}";
        #endregion
    }
}
