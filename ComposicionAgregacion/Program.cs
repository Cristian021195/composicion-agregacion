using System;
using System.Collections.Generic;

namespace ComposicionAgregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class Motor{
            private int potencia;
            private string marca;

            public int Potencia { get => potencia; set => potencia = value; }
            public string Marca { get => marca; set => marca = value; }
        }
        public class Rueda
        {
            private float peso;

            public float Peso { get => peso; set => peso = value; }
        }
        public class Vehiculo {
            private Motor motor;//composicion
            public List<Rueda> Ruedas { get; set; }//agregacion
            public Vehiculo(List<Rueda> Ruedas)
            {
                this.Ruedas = Ruedas;
                motor = new Motor();//composicion
            }
            public void AgregarRueda(Rueda NuevaRueda)//agregacion
            {
                Ruedas.Add(NuevaRueda);//agregacion
            }
        }
    }
}
