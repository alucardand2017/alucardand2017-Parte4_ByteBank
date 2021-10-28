using System;

namespace Bytebank_04Parte
{
    public class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 565);
                ContaCorrente conta2 = new ContaCorrente(378467, 83748);
                conta.Saldo = 100;
                conta2.Saldo = 1000;
                conta.Transferir(1000, conta2);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
                Console.WriteLine("Aconteceu um erro de argumento invalido!");

            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Valor do Saldo = " + e.Saldo);
                Console.WriteLine(" valor da transferencia = " + e.ValorSaque);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo Saldo InsuficienteException!");
            }
            catch (OperacaoFinanceiraException e )
            {                
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo Operação FinanceiraException!");
                Console.WriteLine("\n\n\n INFORMAÇÕES DA INNER EXCEPTION = ");
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            ///Console.WriteLine("saldo conta 1 = " + );
            Console.ReadLine();
            //static void Metodo()
            //{
            //    Divisao.TestaDivisao(0);
            //}
        }
    }
}
