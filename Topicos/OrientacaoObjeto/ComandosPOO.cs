namespace CSharp{ // namespace é o espaço de trabalho agrupa e organiza as funcionalidades e classes dentro dele
    public class ComandosPOO  // classe pública
    {
        // POO = programação orientada a objetos
        public static void Main(){ // método MAIN é o primeiro executado quando seu projeto está rodando, no csharp ele deve começar com o M maiúsculo
            
            Pessoas pessoa = new Pessoas(); // instanciando um novo objeto
                
            pessoa.Cadastrar(); // chamando métodos

            Console.WriteLine("Nome: "+pessoa.nome+"\nIdade: "+pessoa.idade); // chamando atributos

            List<Pessoas> lista = new List<Pessoas>(){ // criando uma lista genérica do tipo Pessoas
                new Pessoas{ 
                    nome = "Pessoa1",
                    idade = 20
                },
                new Pessoas{
                    nome = "Pessoa2",
                    idade = 25
                }
            };

            foreach(var pessoas in lista){ // percorrendo a lista
                Console.WriteLine("Nome: "+pessoas.nome+", Idade:"+pessoas.idade);
            }
            
        }
    }
}