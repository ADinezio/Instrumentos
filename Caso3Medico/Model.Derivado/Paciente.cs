using Caso3Medico.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso3Medico.Model.Derivado
{
    public class Paciente:Persona
    {
        #region constructor
        public Paciente(string nombre) : base(nombre) { }
        #endregion

        #region metodos
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
