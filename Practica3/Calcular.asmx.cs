using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica3
{
    /// <summary>
    /// Descripción breve de Calcular
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Calcular : System.Web.Services.WebService
    {
        [WebMethod]
        public int cuadrado(int cu)
        {
            CalcularFiguras C = new CalcularFiguras();
            C.Area_cuadrado = cu;
            return C.cuadrado(cu);
        }
        [WebMethod]
        public decimal triangulo(decimal Base, decimal Altura)
        {
            CalcularFiguras A = new CalcularFiguras();
            A.Area_triNum1 = Base;
            A.Area_triNum2 = Altura;
            return A.triangulo(Base, Altura);
        }
        [WebMethod]
        public double circulo(double pi, int area)
        {
            CalcularFiguras Ci = new CalcularFiguras();
            Ci.Pi_circulo = pi;
            Ci.Area_circulo = area;
            return Ci.circulo(pi, area);

        }
    }
}
