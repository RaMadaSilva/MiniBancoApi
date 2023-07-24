using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBanco.Core.Entities.ValueObjects
{
    public class Documento
    {
        private Documento()
        {

        }

        public Documento(string nuemroDoBi)
        {
            NumeroDoBI = nuemroDoBi;
        }

        public string NumeroDoBI { get; private set; }
    }
}