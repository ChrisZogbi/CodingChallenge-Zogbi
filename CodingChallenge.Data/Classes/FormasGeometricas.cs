using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormasGeometricas
    {
        #region Propiedades
        public int Tipo { get; set; }
        public decimal Lado { get; set; }
        public decimal Lado2 { get; set; }
        public decimal Perimetro { get; set; }
        public decimal Area { get; set; }
        #endregion

        #region Metodos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        #endregion
    }
}
