using Caso4Animales.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso4Animales.Models.derivados
{
    public class Loro:Animal
    {
        public Loro(string alimento, string nombreAnimal, int edad, double altura, double peso) : base(edad, altura, peso)
        {
            _Alimento = alimento;
            _NombreAnimal = nombreAnimal;
        }


        private string _Alimento;
        private string _NombreAnimal;


        public string Alimento { get => _Alimento; }
        public string NombreAnimal { get => _NombreAnimal; }

        public override string Imprimir()
        {
            return $"Animal : {_NombreAnimal}\n" + base.Imprimir();
        }

        public override string ImprimirComida() => $"Alimento {_Alimento}";
    }
}
