//using _05_Bytebank; - Caso não tivessemos utilizando o namespace
//te

using System;

namespace Bytebank_04Parte
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitido { get; private set; }
        private float _saldo = 100;
        public static double TaxaOperacao { get; private set; }
        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("Tem que ser maior que zero animal!", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("Numero deve ser >0", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia {get;}
        public int Numero {get;}
        public float Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        public float Depostitar
        {
            set
            {
                if (value < 0)
                    return;
                _saldo += value;
            }
        }
        public void Sacar(float valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("Não é permitido saques de valores negativos", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException( _saldo , valor);
            }
            _saldo -= valor;
        }
        public void Transferir(float valor, ContaCorrente destino)
        {
            if(valor <0)
            {
                throw new ArgumentException("Valor inválido para transferencia");
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitido++;
                throw new OperacaoFinanceiraException("Operação Inválida!", ex );
            }

            _saldo -= valor;
            destino.Depostitar = valor;
        }
    }

}












