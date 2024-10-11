using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.1.Modelos
{
    public class Operaciones
    {
        
        public double Sumar(double operando1, double operando2)
        {
            return operando1 + operando2;
        }

        
        public double Restar(double operando1, double operando2)
        {
            return operando1 - operando2;
        }

        
        public double Multiplicar(double operando1, double operando2)
        {
            return operando1 * operando2;
        }

        
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Error no se puede dividir entre cero");
            }
            return dividendo / divisor;
        }
    }
}