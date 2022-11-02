using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Model.Base
{
    public abstract class PiezaAjedrez
    {
        #region constructor
        public PiezaAjedrez(string nombrePieza)
        {
            NombrePieza = nombrePieza;
        }
        #endregion

        #region propiedades
        public string NombrePieza { get; set; }
        #endregion

        #region metodos
        public abstract string Mover(string movimiento);
        #endregion
    }
}
