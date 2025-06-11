using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2.Models
{
    internal class Servicio
    {
        public string[] Nombres;
        public int[] Libretas;
        public double[] Notas;
        public  int Cantidad;

        public double Promedio;

        public double MayorNota;
        public string AlumnoMayorNota;

        public double MenorNota;
        public string AlumnoMenorNota;

        public Servicio() {
            Cantidad = 0;
            Nombres = new string[1000];
            Libretas = new int[1000];
            Notas = new double[1000];
            MayorNota = 0;
            
            MenorNota = 0;
            
            Promedio = 0;
        }

        public bool RegistrarAlumno(int numeroLibreta, string nombre, double nota)
        {
            bool estado = false;
            if (Cantidad < 1000)
            {
                Libretas[Cantidad] = numeroLibreta;
                Nombres[Cantidad] = nombre;
                Notas[Cantidad] = nota;
                Cantidad++;
                estado = true;
            }
            return estado;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;

            for (int i = 0; i < Cantidad; i++) { 
                acumulador += Notas[i];
            }

            if (Cantidad > 0)
            {
                Promedio = acumulador / Cantidad;
                return Promedio;
            }

            return 0;

        }

        public double CalcularAlumnoMayorNota(out string AlumnoMayorNota)
        {
            AlumnoMayorNota = "";
            for (int i =0; i < Cantidad;i++) {
                if (i == 0 || Notas[i] > MayorNota)
                {
                    MayorNota = Notas[i];
                    AlumnoMayorNota = Nombres[i];
                }
            }
            return MayorNota;
        }

        public double CalcularAlumnoMenorNota(out string AlumnoMenorNota)
        {
            AlumnoMenorNota = "";
            for (int i = 0; i < Cantidad; i++)
            {
                if (i == 0 || Notas[i] < MenorNota)
                {
                    MenorNota = Notas[i];
                    AlumnoMenorNota = Nombres[i];
                }
            }
            return MenorNota; 
        }

        public void OrdenarAlumnosPorLibreta()
        {
            for (int i = 0; i < Cantidad-1;i++) {
                for (int j = i+1; j < Cantidad; j++) {
                    if (Libretas[i] > Libretas[j])
                    {
                        int xLibreta = Libretas[i];
                        Libretas[i] = Libretas[j];
                        Libretas[j] = xLibreta;

                        string xNombre = Nombres[i];
                        Nombres[i] = Nombres[j];
                        Nombres[j] = xNombre;

                        double xNota = Notas[i];
                        Notas[i] = Notas[j];
                        Notas[j] = xNota;
                    }
                }
            }
        }

        public int BuscarPorLibreta(int nLibretaBuscado)
        {
            int pos = -1;
            int i = 0;
            while (pos ==-1 && i < Cantidad) {
                if (Libretas[i] == nLibretaBuscado)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }

        public double[] ListarAlumnosSuperaronPromedio(out int CantidadMayores)
        {
            CantidadMayores = 0;
            double[] ListaAlumnosSuperaronPromedio;
            ListaAlumnosSuperaronPromedio = new double[Cantidad];

            for (int i = 0; i < Cantidad; i++)
            {
                if (Notas[i] > Promedio)
                {
                    ListaAlumnosSuperaronPromedio[CantidadMayores] = Notas[i];
                    CantidadMayores++;
                }
            }

            return ListaAlumnosSuperaronPromedio;
        }

    }
}
