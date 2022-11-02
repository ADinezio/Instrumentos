using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso4Animales.Models.Base
{
    public abstract class Animal
    {
        protected Animal(int edad, double altura,double peso)
        {
            _Edad = edad;
            _Altura = altura;
            _Peso = peso;
        }

        private int _Edad;
        private double _Altura;
        private double _Peso;

        public int Edad { get => _Edad; }
        public double Altura { get => _Altura; }
        public double Peso { get => _Peso; }

        public virtual string Imprimir() => $"Edad : {Edad}\nAltura : {Altura}\nPeso : {Peso}";

        public abstract string ImprimirComida();

    }
}
