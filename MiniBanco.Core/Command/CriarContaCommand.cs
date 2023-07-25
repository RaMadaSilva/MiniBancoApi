using Flunt.Notifications;
using Flunt.Validations;
using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public class CriarContaCommand : Notifiable<Notification>, ICommand
    {
        public CriarContaCommand(string primeiroNome, 
                    string ultimoNome, 
                    string documento, 
                    string email, 
                    string telefone, 
                    string rua, 
                    string municipio, 
                    string cidade, 
                    decimal montante)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            Rua = rua;
            Municipio = municipio;
            Cidade = cidade;
            Montante = montante;
        }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Municipio { get; set; }
        public string Cidade { get; set; }
        public decimal Montante { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract<CriarContaCommand>()
                    .Requires()
                    .IsGreaterThan(PrimeiroNome, 3, "PrimeiroNome",  "Primeiro Nome Invalido")
                    .IsGreaterThan(UltimoNome, 3, "UltimoNome",  "Ultimo Nome Invalido")
                    .IsEmail(Email, "Email Invalido")
                    .IsGreaterOrEqualsThan(Montante,20000, "Montante", "Montente insuficiente" )
                    ); 
        }
    }
}