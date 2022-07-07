using EstudosDePOOV2.Interfaces;
using EstudosDePOOV2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDePOOV2.Services
{
    public class ContaCorrenteService : IContaBancariaService
    {
        public void ConsultarSaldo(ContaBancaria conta)
        {
            throw new NotImplementedException();
        }

        public void Depositar(ContaBancaria conta, double valor)
        {
            throw new NotImplementedException();
        }

        public void Sacar(ContaBancaria conta, double valor)
        {
            throw new NotImplementedException();
        }

        public void Transferir(ContaBancaria contaSaida, ContaBancaria contaDestino, double valor)
        {
            throw new NotImplementedException();
        }
    }
}
