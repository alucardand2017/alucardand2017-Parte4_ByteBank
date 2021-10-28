using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_04Parte
{
    //tratamento do erro de saldo insuficiente
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        //sobrecargas

        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
        public SaldoInsuficienteException(double saldo, double valorsaque) :this("falta o valor de " + (valorsaque - saldo))
        {
            Saldo = saldo;
            ValorSaque = valorsaque;

        }
        public SaldoInsuficienteException( string mensagem, Exception excecaoInterna) : base (mensagem, excecaoInterna)
        {

        }
    }
}
