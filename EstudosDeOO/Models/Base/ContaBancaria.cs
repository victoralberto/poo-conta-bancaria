using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDePOOV2.Models.Base
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(int numeroConta, int agencia, Titular titular, double saldo, string password)
        {
            this.NumeroConta = numeroConta;
            this.Titular = titular;
            this.Saldo = saldo;
            this.Password = password;
        }

        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public Titular Titular { get; set; }
        public double Saldo { get; set; }
        public string Password { get; set; }

        public abstract void Sacar();
        public abstract void Depositar();
        public abstract void ConsultarSaldo();
        public abstract void Transferir(ContaBancaria contaSaida, ContaBancaria contaDestino, double valor);

    }
}
