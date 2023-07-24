using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBanco.Core.Entities.ValueObjects
{
    public class Endereco
    {
        public Endereco()
        {

        }

        public Endereco(string rua, string municipio, string cidade)
        {
            Rua = rua;
            Municipio = municipio;
            Cidade = cidade;
        }

        public string Rua { get; private set; }
        public string Municipio { get; private set; }
        public string Cidade { get; private set; }

    }
}