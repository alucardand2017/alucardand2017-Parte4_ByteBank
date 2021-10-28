using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_04Parte
{
    public class Divisao
    {
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                //ContaCorrente conta = null;
                //Console.WriteLine(conta.Saldo);
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero " + numero + " e divisor com " + divisor);
                throw;
            }
            
            
        }
        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}

