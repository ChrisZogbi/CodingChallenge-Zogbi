using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Idioma
    {
        #region Propiedades

        public string ListaVacia { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Circulo { get; set; }
        public string Cuadrado { get; set; }
        public string Triangulo { get; set; }
        public string Rectangulo { get; set; }
        public string Area { get; set; }
        public string Perimetro { get; set; }

        #endregion  

        public Idioma(EIdiomas idioma)
        {
            switch (idioma)
            {
                case EIdiomas.Castellano:
                    this.ListaVacia = "<h1>Lista vacía de formas!</h1>";
                    this.Header = "<h1>Reporte de Formas</h1>";
                    this.Footer = "<br/>TOTAL:<br/>{0} formas Perimetro {1} Area {2}";
                    this.Circulo = "Círculo";
                    this.Cuadrado = "Cuadrado";
                    this.Triangulo = "Triángulo";
                    this.Perimetro = "Perimetro";
                    this.Rectangulo = "Rectángulo";
                    break;
                case EIdiomas.Ingles:
                    this.ListaVacia = "<h1>Empty list of shapes!</h1>";
                    this.Header = "<h1>Shapes report</h1>";
                    this.Footer = "<br/>TOTAL:<br/>{0} shapes Perimeter {1} Area {2}";
                    this.Circulo = "Circle";
                    this.Cuadrado = "Square";
                    this.Triangulo = "Triangle";
                    this.Perimetro = "Perimeter";
                    this.Rectangulo = "Rectangle";
                    break;
                case EIdiomas.Portugues:
                    //Aca se agregarian las mismas propiedades pero en Portugues.
                    break;
                default:
                    break;
            }
        }
    }
}
