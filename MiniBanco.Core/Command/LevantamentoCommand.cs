using Flunt.Notifications;
using Flunt.Validations;
using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public class LevantamentoCommand : Notifiable<Notification>, ICommand
    {
        public LevantamentoCommand(string numeroConta, string documento, decimal montante)
        {
            NumeroConta = numeroConta;
            Documento = documento;
            Montante = montante;
        }

        public string NumeroConta { get; set; }
        public string Documento { get; set; }
        public decimal Montante { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract<LevantamentoCommand>()
                    .Requires()
                    .IsGreaterThan(Montante, 1.00, "Montante", "Montante invalido")
                    );
        }
    }
}