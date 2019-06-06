using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormasGeometricas
    {
        public TrianguloEquilatero(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = (int)EFormas.TrianguloEquilatero;
            CalcularPerimetro();
            CalcularArea();
        }

        public override void CalcularArea()
        {
            this.Area = ((decimal)Math.Sqrt(3) / 4) * this.Lado * this.Lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = this.Lado * 3;
        }
    }
}
