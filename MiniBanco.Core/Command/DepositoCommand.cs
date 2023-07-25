using Flunt.Notifications;
using Flunt.Validations;
using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public class DepositoCommand : TransacaoCommand
    {
        public DepositoCommand(string numeroConta, decimal montante) :
            base(numeroConta, montante)
        {
        }

    }
}