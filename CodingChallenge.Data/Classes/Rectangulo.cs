using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodingChallenge.Data.Enum;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormasGeometricas
    {
        public Rectangulo(decimal lado, decimal lado2)
        {
            this.Lado = lado;
            this.Lado2 = lado2;
            this.Tipo = (int)EFormas.Rectangulo;
            CalcularPerimetro();
            CalcularArea();
        }
        public override void CalcularArea()
        {
            this.Area = this.Lado * this.Lado2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = (this.Lado * 2) + (this.Lado2 * 2);
        }
    }
}
