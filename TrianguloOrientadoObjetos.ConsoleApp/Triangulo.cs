//Dados três valores X, Y, Z, verifiquem se eles podem ser os comprimentos dos lados de um triângulo e se forem
//escrever uma mensagem informando se é um triângulo eqüilátero, isósceles ou escaleno.

//Observações:

//O comprimento de um lado do triângulo é sempre menor do que a soma dos outros dois.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrianguloOrientadoObjetos;

namespace TrianguloOrientadoObjetos.ConsoleApp
{
    class Triangulo
    {
        static void Main(string[] args)
        {
            Console.Title = "Verificação de Triângulo";

            Console.WriteLine("Informe aqui os valores X, Y e Z para verificarmos se eles formarão um triângulo: ");

            Console.Write("Digite o valor de X: ");
            double ValorX = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor de Y: ");
            double ValorY = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de Z: ");
            double ValorZ = double.Parse(Console.ReadLine());

            VerificaTriangulo triangulo = new VerificaTriangulo(ValorX, ValorY, ValorZ);

            Console.WriteLine("\n" + triangulo.GetTipoTriangulo());
            Console.ReadKey();
        }
    }
    class VerificaTriangulo
    {
        private double valorX, valorY, valorZ;

        public VerificaTriangulo(double valorX, double valorY, double valorZ)
        {
            this.valorX = valorX;
            this.valorY = valorY;
            this.valorZ = valorZ;
        }

        private bool VerificaLadosFormamTriangulo()
        {
            return (valorX < valorY + valorZ && valorY < valorX + valorZ && valorZ < valorX + valorY);
        }

        private bool VerificaTrianguloEquilatero()
        {
            return (valorX == valorY && valorY == valorZ);
        }

        private bool VerificaTrianguloIsosceles()
        {
            return (valorX == valorY || valorX == valorZ || valorY == valorZ);
        }

        public string GetTipoTriangulo()
        {
            string tipoTriangulo = "";
            if (VerificaLadosFormamTriangulo())
            {
                if (VerificaTrianguloEquilatero())
                {
                    tipoTriangulo = "É um triângulo Equilátero.";
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (VerificaTrianguloIsosceles())
                {
                    tipoTriangulo = "É um triângulo Isósceles.";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    tipoTriangulo = "É um triângulo Escaleno.";
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            else
            {
                tipoTriangulo = "Não é um triângulo válido.";
                Console.ForegroundColor = ConsoleColor.Red;
            }
            return tipoTriangulo;
        }
    }
}


    