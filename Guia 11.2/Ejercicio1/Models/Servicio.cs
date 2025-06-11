using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        public int[] Lista;
        private int acumulador;

        public int Contador;
        public int Mayor;
        public int Menor;
        public double Promedio;

        public Servicio()
        {
            Lista = new int[1000];
            Contador = 0;
            acumulador = 0;
            Mayor = 0;
            Menor = 0;
        }

        public void RegistrarValor(int num)
        {
            Lista[Contador] = num;
            Contador++;
            
        }
        public double CalcularPromedio()
        {
            for (int i = 0; i < Contador;  i++) {
                acumulador += Lista[i];
            }

            if (Contador > 0)
            {
                Promedio = (acumulador * 1.0) / Contador;
            }
            return Promedio;
        }
        public double CalcularMaximo()
        {
            for (int i = 0; i < Contador; i++)
            {
                if (i == 0 || Lista[i] > Mayor)
                {
                    Mayor = Lista[i];
                    //PosicionMayor = i;
                }
            }
            return Mayor;
        }
        public double CalcularMinimo()
        {
            for (int i = 0; i < Contador; i++)
            {
                if (i == 0 || Lista[i] < Menor)
                {
                    Menor = Lista[i];
                    //PosicionMenor = i;
                }
            }
            return Menor;
        }

        public void OrdenarLista()
        {
            for (int i = 0;i < Contador-1;i++) {
                for (int j = i+1; j < Contador; j++) {
                    if (Lista[i] > Lista[j]) { 
                        int x = Lista[i];
                        Lista[i] = Lista[j];
                        Lista[j] = x;
                    }
                }
            }
        }

        public int BuscarValor(int buscado)
        {
            int pos = -1;
            int i = 0;
            while (pos == -1 && i < Lista.Length)
            {
                if (Lista[i] == buscado) {
                    pos = i;
                }
                i++;
            }

            return pos;
        }

        
        public int[] ListaSuperioresAlPromedio(out int ContadorSuperiores)
        {

            ContadorSuperiores = 0;
            int[] nuevaLista;
            nuevaLista = new int[Contador];

            for (int i = 0; i < Contador; i++) {
                if (Lista[i] > Promedio)
                {
                    nuevaLista[ContadorSuperiores] = Lista[i];
                    ContadorSuperiores++;
                }
            }

            return nuevaLista;
        }
    }
}
