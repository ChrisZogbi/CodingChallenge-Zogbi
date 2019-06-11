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
                sb.Append(Idioma.Header);

                if (formas.Where(x => x.Tipo == (int)EFormas.Cuadrado).ToList().Count > 0)
                    sb.Append(EscrituraHelper.EscribirDatosForma(formas.Where(x => x.Tipo == (int)EFormas.Cuadrado).ToList().Count, EFormas.Cuadrado, formas.Where(x => x.Tipo == (int)EFormas.Cuadrado).ToList().Sum(x => x.Area).ToString("#.##"), formas.Where(x => x.Tipo == (int)EFormas.Cuadrado).ToList().Sum(x => x.Perimetro).ToString("#.##"), Idioma.Cuadrado, Idioma.Perimetro));

                if (formas.Where(x => x.Tipo == (int)EFormas.Circulo).ToList().Count > 0)
                    sb.Append(EscrituraHelper.EscribirDatosForma(formas.Where(x => x.Tipo == (int)EFormas.Circulo).ToList().Count, EFormas.Circulo, formas.Where(x => x.Tipo == (int)EFormas.Circulo).ToList().Sum(x => x.Area).ToString("#.##"), formas.Where(x => x.Tipo == (int)EFormas.Circulo).ToList().Sum(x => x.Perimetro).ToString("#.##"), Idioma.Circulo, Idioma.Perimetro));

                if (formas.Where(x => x.Tipo == (int)EFormas.TrianguloEquilatero).ToList().Count > 0)
                    sb.Append(EscrituraHelper.EscribirDatosForma(formas.Where(x => x.Tipo == (int)EFormas.TrianguloEquilatero).ToList().Count, EFormas.TrianguloEquilatero, formas.Where(x => x.Tipo == (int)EFormas.TrianguloEquilatero).ToList().Sum(x => x.Area).ToString("#.##"), formas.Where(x => x.Tipo == (int)EFormas.TrianguloEquilatero).ToList().Sum(x => x.Perimetro).ToString("#.##"), Idioma.Triangulo, Idioma.Perimetro));

                if (formas.Where(x => x.Tipo == (int)EFormas.Rectangulo).ToList().Count > 0)
                    sb.Append(EscrituraHelper.EscribirDatosForma(formas.Where(x => x.Tipo == (int)EFormas.Rectangulo).ToList().Count, EFormas.Rectangulo, formas.Where(x => x.Tipo == (int)EFormas.Rectangulo).ToList().Sum(x => x.Area).ToString("#.##"), formas.Where(x => x.Tipo == (int)EFormas.Rectangulo).ToList().Sum(x => x.Perimetro).ToString("#.##"), Idioma.Rectangulo, Idioma.Perimetro));

                // FOOTER
                sb.Append(EscrituraHelper.EscribirFooter(formas.Count, (formas.Sum(x => x.Perimetro)).ToString("#.##"), (formas.Sum(x => x.Area)).ToString("#.##"), Idioma.Footer));

                //sb.Append("TOTAL:<br/>");
                //sb.Append(string.Format("{0} {1} ", formas.Count, ((EIdiomas)idioma == EIdiomas.Castellano ? "formas" : "shapes")));
                //sb.Append(string.Format("{0} {1} ", ((EIdiomas)idioma == EIdiomas.Castellano ? "Perimetro" : "Perimeter"), (formas.Sum(x => x.Perimetro)).ToString("#.##")));
                //sb.Append(string.Format("Area {0}", (formas.Sum(x => x.Area)).ToString("#.##")));
            }

            return sb.ToString();
        }
    }
}
