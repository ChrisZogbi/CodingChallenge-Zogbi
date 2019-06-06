/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Main
    {
        public static string Imprimir(List<FormasGeometricas> formas, int idioma)
        {
            var sb = new StringBuilder();

            Idioma Idioma = new Idioma((EIdiomas)idioma);

            if (!formas.Any())
            {
                sb.Append(Idioma.ListaVacia);
            }
            else
            {
                List<Cuadrado> Cuadrados = new List<Cuadrado>();
                List<TrianguloEquilatero> TriangulosEquilateros = new List<TrianguloEquilatero>();
                List<Circulo> Circulos = new List<Circulo>();
                List<Rectangulo> Rectangulos = new List<Rectangulo>();

                sb.Append(Idioma.Header);

                foreach (var forma in formas)
                {
                    switch ((EFormas)forma.Tipo)
                    {
                        case EFormas.Cuadrado:
                            Cuadrados.Add(new Cuadrado(forma.Lado));
                            break;
                        case EFormas.TrianguloEquilatero:
                            TriangulosEquilateros.Add(new TrianguloEquilatero(forma.Lado));
                            break;
                        case EFormas.Circulo:
                            Circulos.Add(new Circulo(forma.Lado));
                            break;
                        case EFormas.Rectangulo:
                            Rectangulos.Add(new Rectangulo(forma.Lado, forma.Lado2));
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(@"Forma desconocida");
                    }
                }

                if (Cuadrados.Count > 0)
                    sb.Append(string.Format("{0} {1} | Area {2} | {3} {4} <br/>", Cuadrados.Count, (Cuadrados.Count > 1 ? string.Format("{0}s", Idioma.Cuadrado) : Idioma.Cuadrado), Cuadrados.Sum(x => x.Area).ToString("#.##"), Idioma.Perimetro, Cuadrados.Sum(x => x.Perimetro).ToString("#.##")));

                if (Circulos.Count > 0)
                    sb.Append(string.Format("{0} {1} | Area {2} | {3} {4} <br/>", Circulos.Count, (Circulos.Count > 1 ? string.Format("{0}s", Idioma.Circulo) : Idioma.Circulo), Circulos.Sum(x => x.Area).ToString("#.##"), Idioma.Perimetro, Circulos.Sum(x => x.Perimetro).ToString("#.##")));

                if (TriangulosEquilateros.Count > 0)
                    sb.Append(string.Format("{0} {1} | Area {2} | {3} {4} <br/>", TriangulosEquilateros.Count, (TriangulosEquilateros.Count > 1 ? string.Format("{0}s", Idioma.Triangulo) : Idioma.Triangulo), TriangulosEquilateros.Sum(x => x.Area).ToString("#.##"), Idioma.Perimetro, TriangulosEquilateros.Sum(x => x.Perimetro).ToString("#.##")));

                if (Rectangulos.Count > 0)
                    sb.Append(string.Format("{0} {1} | Area {2} | {3} {4} <br/>", Rectangulos.Count, (Rectangulos.Count > 1 ? string.Format("{0}s", Idioma.Rectangulo) : Idioma.Rectangulo), Rectangulos.Sum(x => x.Area).ToString("#.##"), Idioma.Perimetro, Rectangulos.Sum(x => x.Perimetro).ToString("#.##")));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(string.Format("{0} {1} ", formas.Count, ((EIdiomas)idioma == EIdiomas.Castellano ? "formas" : "shapes")));
                sb.Append(string.Format("{0} {1} ", ((EIdiomas)idioma == EIdiomas.Castellano ? "Perimetro" : "Perimeter"), (Cuadrados.Sum(x => x.Perimetro) + Circulos.Sum(x => x.Perimetro) + TriangulosEquilateros.Sum(x => x.Perimetro) + Rectangulos.Sum(x => x.Perimetro)).ToString("#.##")));
                sb.Append(string.Format("Area {0}", (Cuadrados.Sum(x => x.Area) + Circulos.Sum(x => x.Area) + TriangulosEquilateros.Sum(x => x.Area) + Rectangulos.Sum(x => x.Area)).ToString("#.##")));
            }

            return sb.ToString();
        }
    }
}
