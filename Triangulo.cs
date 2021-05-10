using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloExercicio
{
    class Triangulo
    {
        public double ladoA, ladoB, ladoC;
        private bool tipoTriangulo;

        
        
        public void VerificarTipoTriangulo() {

            if (!EhInvalido())
            {
                if (Equilatero())
                    Console.WriteLine("O triângulo é equilátero");

                if (Isosceles())
                    Console.WriteLine("O triângulo é isósceles");

                if (Escaleno())
                    Console.WriteLine("O triângulo é escaleno");
            }
        
        }

        private bool EhInvalido()
        {

            bool invalido = true;

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
            {

                invalido = false;

            }

            else
            {
                Console.WriteLine("Lados do triângulo são inválidos");
            }

            return invalido;
        }


        private bool Equilatero() {

            tipoTriangulo = false;

            if (ladoA == ladoB && ladoB == ladoC) {

                tipoTriangulo = true;
            }

            return tipoTriangulo;

        }

        private bool Isosceles() {

            tipoTriangulo = false;

            if ((ladoA == ladoB && ladoB != ladoC) || (ladoB == ladoC && ladoC != ladoA) || (ladoC == ladoA && ladoA != ladoB)) {

                tipoTriangulo = true;
            }

            return tipoTriangulo;
        }

       private bool Escaleno() {

            tipoTriangulo = false;

            if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC) {

                tipoTriangulo = true;

            }

            return tipoTriangulo;
        
        }

    }
}
