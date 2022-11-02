using Caso5Transporte.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso5Transporte.Model.Derivados
{
    public class Auto:Transporte
    {
        #region contructores
        public Auto(string marca,string modelo,int maxFuel, int maxNroDePasajeros, int velocidad) : base(maxFuel, maxNroDePasajeros, velocidad)
        {
            _Marca = marca;
            _Modelo = modelo;
        }
        #endregion

        #region propiedades
        private string _Marca;
        private string _Modelo;
        #endregion

        #region metodos
        public string Modelo { get => _Modelo; }

        public string Marca { get => _Marca; }  

        public override string Acelerar()
        {
            return "El auto esta " +base.Acelerar();
        }

        public override string Desacelerar()
        {
            return "El auto esta " + base.Desacelerar();
        }

        public string DoblarAIzq() => "El auto esta doblando a la Izquierda";

        public string DoblarADcha() => "El auto esta doblando a la Derecha";
        #endregion
    }
}
