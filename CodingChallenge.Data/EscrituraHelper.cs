using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data
{
    public static class EscrituraHelper
    {
        public static string EscribirDatosForma(int NumeroDeFormas, EFormas Tipo, string Area, string Perimetro, string IdiomaForma, string IdiomaPerimetro)
        {
            return
                string.Format("{0} {1} | Area {2} | {3} {4} <br/>", NumeroDeFormas, (NumeroDeFormas > 1 ? string.Format("{0}s", IdiomaForma) : IdiomaForma), Area, IdiomaPerimetro, Perimetro);
        }

        public static string EscribirFooter(int NumeroDeFormas, string Perimetro, string Area, string Footer)
        {
            return string.Format(Footer, NumeroDeFormas, Perimetro, Area);
        }

    }
}
