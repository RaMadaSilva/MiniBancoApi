using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBanco.Core.Entities.ValueObjects
{
    public class Email : IEquatable<Email>
    {
        public Email()
        {

        }

        public Email(string correiroElectronico)
        {
            CorreiroElectronico = correiroElectronico;
        }

        public string CorreiroElectronico { get; private set; }

        public bool Equals(Email? other)
        {
            return CorreiroElectronico == other.CorreiroElectronico;
        }
    }
}