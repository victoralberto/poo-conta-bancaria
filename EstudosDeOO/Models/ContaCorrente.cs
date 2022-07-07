using EstudosDePOOV2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDePOOV2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int numeroConta, int agencia, Titular titular, double saldo, string password) : base(numeroConta, agencia, titular, saldo, password)
        {
            this.NumeroConta = numeroConta;
            this.Titular = titular;
            this.Saldo = saldo;
            this.Password = password;
        }

        public override void ConsultarSaldo()
        {
            throw new NotImplementedException();
        }

        public override void Depositar()
        {
            throw new NotImplementedException();
        }

        public override void Sacar()
        {
            throw new NotImplementedException();
        }

        public override void Transferir(ContaBancaria contaSaida, ContaBancaria contaDestino, double valor)
        {
            throw new NotImplementedException();
        }
    }
}
