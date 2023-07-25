using Flunt.Notifications;
using Flunt.Validations;
using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public class TransferenciaBancariaCommand : TransacaoCommand
    {
        public TransferenciaBancariaCommand(string contaBancaria, decimal montante)
            : base(contaBancaria, montante)
        {
        }

    }
}