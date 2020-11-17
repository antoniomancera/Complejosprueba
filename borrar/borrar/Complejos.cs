using System;
using System.Collections.Generic;
using System.Text;

namespace borrar
{
    public class Complejos
    {
        public Complejos()
        {

        }

        private double real;
        private double imaginario;
        public Complejos(double Real, double Imaginario)
        {
            real = Real;
            imaginario = Imaginario;
        }
        public double Real { get; set; }
        public double Imaginario { get; set; }
    }
}