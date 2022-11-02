using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaInstrumento.Model.Derivados;
using LibreriaAjedrez.Model.Derivadas;
using Caso3Medico.Model.Derivado;
using Caso4Animales.Models.derivados;
using Caso5Transporte.Model.Derivados;

namespace WindowsAppInstrumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarInstrumentos_Click(object sender, EventArgs e)
        {
            Piano piano = new Piano();
            MessageBox.Show(piano.Afinar("piano"));
            Guitarra guitarra = new Guitarra();
            MessageBox.Show(guitarra.Afinar("guitarra"));
            Violin violin = new Violin();
            MessageBox.Show(violin.Afinar("violin"));
        }

        private void btnMovimientoPiezas_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon("peon");
            MessageBox.Show(peon.Mover("Dos o una casillas en su primer movimiento y despues mueve de a una casilla"));
            Caballo caballo = new Caballo("caballo");
            MessageBox.Show(caballo.Mover("Su movimiento es en L, dos casillas hacia un lado y una para otro."));
            Torre torre = new Torre("torre");
            MessageBox.Show(torre.Mover("Su movimiento es vertical u horizontal"));
        }

        private void btnMostrarPersonas_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico("Juan");
            MessageBox.Show($"Medico : {medico.ToString()}");
            Paciente paciente = new Paciente("Agustin");
            MessageBox.Show($"Paciente : {paciente.ToString()}");
        }

        private void btnMostrarAnimales_Click(object sender, EventArgs e)
        {
            Leon leoncito = new Leon("Carne","Leon",5,1.40,120);
            MessageBox.Show(leoncito.Imprimir());
            MessageBox.Show(leoncito.ImprimirComida());

            Conejo conejito = new Conejo("Pasto", "Conejo",2,0.45,3);
            MessageBox.Show(conejito.Imprimir());
            MessageBox.Show(conejito.ImprimirComida());

            Loro lorito = new Loro("Insectos", "Loro", 3,0.30, 2);
            MessageBox.Show(lorito.Imprimir());
            MessageBox.Show(lorito.ImprimirComida());
        }

        private void btnTransportes_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion(1800,4,10000,200,900);
            MessageBox.Show(avion.Descender());
            MessageBox.Show(avion.Ascender());
            MessageBox.Show(avion.Acelerar());
            MessageBox.Show(avion.Desacelerar());

            Auto auto = new Auto("Fiat","Toro",60,5,220);
            MessageBox.Show(auto.DoblarADcha());
            MessageBox.Show(auto.DoblarAIzq());
            MessageBox.Show(auto.Acelerar());
            MessageBox.Show(auto.Desacelerar());
        }
    }
}
