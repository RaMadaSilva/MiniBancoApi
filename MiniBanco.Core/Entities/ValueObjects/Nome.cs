namespace MiniBanco.Core.Entities.ValueObjects
{
    public class Nome
    {
        public Nome()
        {

        }

        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {UltimoNome}";
        }
    }
}