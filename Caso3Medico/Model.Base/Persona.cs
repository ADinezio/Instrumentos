using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3Medico.Model.Base
{
    public abstract class Persona
    {
        #region constructor
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        #endregion

        #region propiedades
        public string Nombre { get; set; }
        #endregion

        #region metodos
        public override string ToString() => Nombre;
        #endregion
    }
}
