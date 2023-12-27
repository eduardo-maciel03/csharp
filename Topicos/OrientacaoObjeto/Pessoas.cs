namespace CSharp{
    public class Pessoas // classe Pessoas para exemplos
    {
        public string? nome; // "?" na frente da string permite valores nulos
        public int idade;

        public Pessoas() // construtor, deve ser do mesmo nome da classe, serve para inicializar o objeto com valores pré-definidos e/ou receber parametros
        {
            
        }

        public Pessoas(int idade) // pode ter mais de um construtor, cada um recebe ou define algum valor diferente
        {
            this.idade = idade; // "this" representa a variável da classe
        }

        public void Cadastrar(){
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine()); // convertendo o valor para int
        }
    }
}