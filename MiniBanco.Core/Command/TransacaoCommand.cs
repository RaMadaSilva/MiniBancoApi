using Flunt.Notifications;
using Flunt.Validations;
using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public abstract class TransacaoCommand : Notifiable<Notification>, ICommand
    {
        protected TransacaoCommand(string numeroConta, decimal montante)
        {
            NumeroConta = numeroConta;
            Montante = montante;
        }

        public string NumeroConta { get; set; }
        public decimal Montante { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract<TransacaoCommand>().Requires());
        }
    }
}