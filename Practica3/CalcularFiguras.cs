using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica3
{
    public class CalcularFiguras
    {
        public int Area_cuadrado { get; set; }
        public decimal Area_triNum1 { get; set; }
        public decimal Area_triNum2 { get; set; }
        public int Area_circulo { get; set; }
        public double Pi_circulo { get; set; }
        public int cuadrado(int cu)
        {
            Area_cuadrado = cu;
            return Area_cuadrado * Area_cuadrado;
        }
        public decimal triangulo(decimal Base, decimal Altura)
        {
            Area_triNum1 = Base;
            Area_triNum2 = Altura;
            return Area_triNum1 * Area_triNum2 / 2;
        }
        public double circulo(double pi, int area)
        {
            Pi_circulo = pi;
            Area_circulo = area;
            return Pi_circulo * Area_circulo * Area_circulo;
        }
    }
}