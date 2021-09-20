using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida al operador pasado y realiza la operación pedida entre los números pasados por parámetro
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operador que indica el tipo de operación a realizar</param>
        /// <returns>El resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operadorValidado = ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el operador sea valido y si no lo es devuelve un mas
        /// </summary>
        /// <param name="operador">Operador a validar</nparam>
        /// <returns>El operador pasado en forma de cadea o un "+" si no se paso un operador válido</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }

            return '+';
        }
    }
}
