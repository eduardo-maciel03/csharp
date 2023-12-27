using DigiBank.Contratos;

namespace DigiBank.Classes
{
    public abstract class Conta : Banco, IConta // classe Conta herda da classe Banco e implementa a interface IConta
    {
        public Conta()
        {
            this.NumeroAgencia = "001";
            Conta.NumeroContaSequencial++;

            this.Movimentacoes = new List<Extrato>();
        }

        public double Saldo { get; protected set; } 
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return this.Saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            this.Movimentacoes.Add(new Extrato(dataAtual, "Depósito", valor));
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor > this.ConsultaSaldo())
            {
                return false;
            }

            DateTime dataAtual = DateTime.Now; // setando a data atual
            this.Movimentacoes.Add(new Extrato(dataAtual, "Saque", -valor));

            this.Saldo -= valor;
            return true;
        }

        public string GetCodigoDoBanco()
        {
            return this.CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetNumeroConta()
        {
            return this.NumeroConta;
        }

        public List<Extrato> GetExtratoList()
        {
            return this.Movimentacoes;
        }
    }
}
