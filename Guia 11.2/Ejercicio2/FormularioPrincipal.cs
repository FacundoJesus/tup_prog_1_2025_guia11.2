using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormularioPrincipal : Form
    {
        Servicio servicio = new Servicio();

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (tbLibreta.Text != "" && tbNombre.Text != "" && tbNota.Text != "")
            {
                int nLibreta = Convert.ToInt32(tbLibreta.Text);
                string nombre = tbNombre.Text;
                double nota = Convert.ToDouble(tbNota.Text);
                servicio.RegistrarAlumno(nLibreta, nombre, nota);
            }
            else
            {
                MessageBox.Show("Debe completar los 3 Datos!");
            }

            tbLibreta.Clear();
            tbNombre.Clear();
            tbNota.Clear();
        }

        private void btnBuscarNLibreta_Click(object sender, EventArgs e)
        {
            if (tbBuscarLibreta.Text != "")
            {
                int numLibreta = Convert.ToInt32(tbBuscarLibreta.Text);
                servicio.BuscarPorLibreta(numLibreta);

                if (servicio.BuscarPorLibreta(numLibreta) != -1)
                {
                    tbResultado.Text = $"índice: {servicio.BuscarPorLibreta(numLibreta)}";
                }
                else
                {
                    tbResultado.Text = $"El Número de Libreta no se encuentra en la Lista";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el Número de Libreta a Buscar");
            }

            tbBuscarLibreta.Clear();
        }

        private void btnMayoryMenor_Click(object sender, EventArgs e)
        {
            string AlumnoMayorNota = "";
            double MayorNota = servicio.CalcularAlumnoMayorNota(out AlumnoMayorNota);
            string AlumnoMenorNota = "";
            double MenorNota = servicio.CalcularAlumnoMenorNota(out AlumnoMenorNota);


            tbResultado.Text = $@"Mayor Nota: {MayorNota} , Alumno Mayor Nota: {AlumnoMayorNota}
Menor Nota: {MenorNota} , Alumno Menor Nota: {AlumnoMenorNota} ";
        }

        private void btnCantidadAlumnos_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            tbResultado.Text = $"Cantidad Alumnos: {servicio.Cantidad}";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            double promedio = servicio.CalcularPromedio();
            tbResultado.Text = $"Promedio: {promedio:f2}";
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();

            servicio.OrdenarAlumnosPorLibreta();

            for (int i = 0; i < servicio.Cantidad; i++)
            {
                tbResultado.Text += $"Nro Libreta: {servicio.Libretas[i]}, Alumno: {servicio.Nombres[i]}, Nota:{servicio.Notas[i]:f2}";
            }
        }

        private void btnListaSuperiorPromedio_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();

            int contadorSuperiores;
            double[] ListaSuperiorPromedio = servicio.ListarAlumnosSuperaronPromedio(out contadorSuperiores);

            for (int i = 0; i < contadorSuperiores; i++)
            {
                tbResultado.Text += $"{ListaSuperiorPromedio[i],3}";
            }
            
        }
    }
}
