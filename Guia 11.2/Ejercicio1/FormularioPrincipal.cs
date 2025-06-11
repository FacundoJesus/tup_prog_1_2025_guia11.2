using System.Transactions;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormularioPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarNumero_Click(object sender, EventArgs e)
        {
            if (tbIngresoNumero.Text != "")
            {
                int numero = Convert.ToInt32(tbIngresoNumero.Text);
                servicio.RegistrarValor(numero);
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor");
            }

            tbIngresoNumero.Clear();

        }

        private void btnMaxYMin_Click(object sender, EventArgs e)
        {
            double nMaximo = servicio.CalcularMaximo();
            lbMaximo.Text = $"{nMaximo}";

            double nMinimo = servicio.CalcularMinimo();
            lbMinimo.Text = $"{nMinimo}";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = servicio.CalcularPromedio();
            lbPromedio.Text = $"{promedio:f2}";
        }

        private void btnCantidadIngresos_Click(object sender, EventArgs e)
        {
            lbCantidadIngresos.Text = $"{servicio.Contador}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            int valorBuscado = Convert.ToInt32(tbValorBuscado.Text);

            if (servicio.BuscarValor(valorBuscado) != -1)
            {
                int indiceEncontrado = Convert.ToInt32(servicio.BuscarValor(valorBuscado));
                tbValorBuscado.Text = $"Posición: {indiceEncontrado}";
            }
            else
            {
                tbValorBuscado.Text = "No se encuentra.";
            }

        }

        private void btnMostrarListaOrdenada_Click(object sender, EventArgs e)
        {
            tbListas.Clear();

            servicio.OrdenarLista();

            for (int i = 0; i < servicio.Contador; i++)
            {
                tbListas.Text += $"{servicio.Lista[i],3}\n";
            }
        }

        private void btnListaSuperiorAlPromedio_Click(object sender, EventArgs e)
        {
            tbListas.Clear();

            int cantidad;
            int [] ListaSupPromedio = servicio.ListaSuperioresAlPromedio(out cantidad);

            if (servicio.Promedio > 0) {
                for (int i = 0; i < cantidad; i++) {
                    tbListas.Text += $"{ListaSupPromedio[i],3}\n";
                }
            }
            else
            {
                tbListas.Text = "Debe calcular el promedio";
            }
        }
    }
}
