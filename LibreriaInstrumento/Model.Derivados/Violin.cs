using LibreriaInstrumento.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaInstrumento.Model.Derivados
{
    public class Violin:InstrumentoMusical
    {
        public override string Afinar(string instrumento)
        {
            return "Afinando " + instrumento;
        }
    }
}
