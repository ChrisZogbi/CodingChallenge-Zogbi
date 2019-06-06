using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormasGeometricas
    {
        public Cuadrado(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = (int)EFormas.Cuadrado;
            CalcularPerimetro();
            CalcularArea();
        }

        public override void CalcularArea()
        {
            this.Area += this.Lado * this.Lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro += this.Lado * 4;
        }
    }
}
