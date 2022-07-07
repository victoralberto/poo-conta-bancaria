using EstudosDePOOV2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDePOOV2.Interfaces
{
    public interface IContaBancariaService
    {
        public void Sacar(ContaBancaria conta, double valor);
        public void Depositar(ContaBancaria conta, double valor);
        public void ConsultarSaldo(ContaBancaria conta);
        public void Transferir(ContaBancaria contaSaida, ContaBancaria contaDestino, double valor);
    }
}
