using MiniBanco.Core.Command.Interface;

namespace MiniBanco.Core.Command
{
    public class ResultadoCommand : IResultadoCommand
    {
        public ResultadoCommand(bool sucesso, string mensagem, object objecto)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Objecto = objecto;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public object Objecto { get; set; }
    }
}