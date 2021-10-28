using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_04Parte
{
    public class Cliente
    {
        private string _cpf;
        public string Profissao { get; set; }
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }
        

    
    }
}
