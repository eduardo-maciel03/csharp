using DigiBank.Contratos;

namespace DigiBank.Classes
{
    public class Pessoa
    {
        public string Nome { get; private set; } 
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public IConta Conta { get; set; } // agregação, pode acessar os métodos da Conta através da classe Pessoa

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public void SetSenha(string senha)
        {
            this.Senha = senha;
        }
    }
}
