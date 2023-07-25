using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBanco.Core.Command
{
    public class PagamentoBancarioCommand : TransacaoCommand
    {
        public PagamentoBancarioCommand(string numeroConta, decimal montante)
            : base(numeroConta, montante)
        {
        }
    }
}