using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Main.Imprimir(new List<FormasGeometricas>(), (int)Enum.EIdiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Main.Imprimir(new List<FormasGeometricas>(), (int)Enum.EIdiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormasGeometricas> {new Cuadrado(5)};

            var resumen = Main.Imprimir(cuadrados, (int)Enum.EIdiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormasGeometricas>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Main.Imprimir(cuadrados, (int)Enum.EIdiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormasGeometricas>
            {
                new Cuadrado(5),
                new Circulo( 3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new Rectangulo(3, 2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(1,2)
            };

            var resumen = Main.Imprimir(formas, (int)Enum.EIdiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Rectangles | Area 8 | Perimeter 16 <br/>TOTAL:<br/>9 shapes Perimeter 113,66 Area 99,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormasGeometricas>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Main.Imprimir(formas, (int)Enum.EIdiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulos = new List<FormasGeometricas> { new Rectangulo(5, 6) };

            var resumen = Main.Imprimir(rectangulos, (int)Enum.EIdiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 30 | Perimetro 22 <br/>TOTAL:<br/>1 formas Perimetro 22 Area 30", resumen);
        }
    }
}
