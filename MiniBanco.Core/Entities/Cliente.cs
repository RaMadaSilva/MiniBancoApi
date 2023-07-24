using MiniBanco.Core.Entities.ValueObjects;

namespace MiniBanco.Core.Entities
{
    public class Cliente : Entity, IEquatable<Cliente>
    {
        private Cliente()
        {

        }

        public Cliente(Nome nomecompleto,
                    Documento documento,
                    string telefone,
                    Email email,
                    Endereco enderco,
                    ContaBancaria conta)
        {
            Nomecompleto = nomecompleto;
            Documento = documento;
            Telefone = telefone;
            Email = email;
            Enderco = enderco;
            Conta = conta;
        }

        public Nome Nomecompleto { get; private set; }
        public Documento Documento { get; private set; }
        public string Telefone { get; private set; }
        public Email Email { get; private set; }
        public Endereco Enderco { get; private set; }
        public ContaBancaria Conta { get; private set; }

        public bool Pagamento(decimal montante, ContaBancaria outro)
        {
            if (Conta.Saldo < montante)
                return false;

            Conta.Trasferencia(montante, outro);
            return true;
        }

        public bool Equals(Cliente? other)
        {
            return Nomecompleto == other.Nomecompleto &&
                    Email == other.Email;
        }
    }
}