using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormasGeometricas
    {
        public Circulo(decimal lado)
        {
            this.Lado = lado;
            this.Tipo = (int)EFormas.Circulo;
            CalcularPerimetro();
            CalcularArea();
        }

        public override void CalcularArea()
        {
            this.Area = (decimal)Math.PI * (this.Lado / 2) * (this.Lado / 2);
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = (decimal)Math.PI * this.Lado;
        }
    }
}
