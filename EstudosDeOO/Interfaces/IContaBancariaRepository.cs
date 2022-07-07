using EstudosDePOOV2.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosDePOOV2.Interfaces
{
    public interface IContaBancariaRepository
    {
        void Create(ContaBancaria conta);
        void Read(ContaBancaria conta);
        void Read();
        void Update(ContaBancaria conta, ContaBancaria dataConta);
        void Delete(ContaBancaria conta);
    }
}
