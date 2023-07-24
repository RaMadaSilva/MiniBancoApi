namespace MiniBanco.Core.Entities
{
    public class ContaBancaria : Entity, IEquatable<ContaBancaria>
    {

        public ContaBancaria(decimal saldo)
        {
            NumeroDaConta = Gerador();
            Saldo = saldo;
        }

        public string NumeroDaConta { get; private set; }
        public decimal Saldo { get; private set; }

        public void Depositar(decimal montente)
        {
            Saldo += montente;
        }

        public bool Levantar(decimal montate)
        {
            if (montate > Saldo)
                return false;
            Saldo -= montate;
            return true;
        }

        public bool Trasferencia(decimal montate, ContaBancaria conta)
        {
            //Minha ideia para a transferencia 
            //1. Verificar se a conta tem valores suficiente para trasferer
            //2. Verificar se a conta de destino existe 
            //3. efectuar o deposito na conta de destino
            if (!Levantar(montate))
                return false;
            conta.Depositar(montate);
            return true;

        }

        public bool Equals(ContaBancaria? other)
        {
            return NumeroDaConta == other.NumeroDaConta;
        }
        private string Gerador()
        {
            string numeroAleatorio = "";
            var random = new Random();
            var possibilidades = Enumerable.Range(0, 10).ToList();
            var resultado = possibilidades.OrderBy(number => random.Next()).Take(10).ToArray();
            return numeroAleatorio = String.Join("", resultado);
        }
    }
}