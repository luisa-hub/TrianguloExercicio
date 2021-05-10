using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Equilátero
            Triangulo triangulo = new Triangulo();

            triangulo.ladoA = 2;
            triangulo.ladoB = 2;
            triangulo.ladoC = 2;

            triangulo.VerificarTipoTriangulo();

            //Isosceles
            Triangulo trianguloIsosceles = new Triangulo();

            trianguloIsosceles.ladoA = 3;
            trianguloIsosceles.ladoB = 3;
            trianguloIsosceles.ladoC = 4;

            trianguloIsosceles.VerificarTipoTriangulo();


            // Escaleno
            Triangulo trianguloEscaleno = new Triangulo();

            trianguloEscaleno.ladoA = 5;
            trianguloEscaleno.ladoB = 3;
            trianguloEscaleno.ladoC = 4;

            trianguloEscaleno.VerificarTipoTriangulo();

            //TrianguloInvalido

            Triangulo trianguloInvalido = new Triangulo();

            trianguloInvalido.ladoA = 5;
            trianguloInvalido.ladoB = 2;
            trianguloInvalido.ladoC = 1;

            trianguloInvalido.VerificarTipoTriangulo();
        }
    }
}
