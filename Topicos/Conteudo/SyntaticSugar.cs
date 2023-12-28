// Syntactic Sugar ou Syntax Sugar, 
// é um termo utilizado para quando uma linguagem de programação oferece uma forma mais fácil de ser lida e escrita.

// Usar syntactic sugar refere-se a escrever um código de forma alternativa ao modo tradicional, 
// com a finalidade de escrever menos código e torná-lo mais expressivo. Alguns exemplos:

namespace CSharp{
    public class SyntacticSugar{
        public void SyntaxSugar(){
            // primeiro exemplo - nullable
            // para permitir que sua variável possa receber algum valor nulo existem algumas possibilidades

            // 1 - é uma forma certa, mas você pode tornar mais fácil
            System.Nullable<int> numero;

            // 2 - assim você terá um erro, pois int é um tipo de valor não anulável diretamente
            // int numero1 = null; 

            // 3 - com syntatic sugar
            int? numero2;

            // segundo exemplo

            string NomePrincipal = null;
            string NomeAlternativo = "Eduardo";

            string nome = NomePrincipal != null ? NomePrincipal : NomeAlternativo;

            string Nome = NomePrincipal ?? NomeAlternativo;

            // o código acima é para testar se a variável NomePrincipal não é nula e se caso for, 
            // então atribuir a variável NomeAlternativo para a variável Nome.
            // a primeira forma é um op. ternário, que já é um jeito de reduzir seu código, 
            // porém não é syntatic sugar, como a segunda.
            //  o "??" serve apenas para testar se um valor é nulo.

            // terceiro exemplo

            FileStream f = new FileStream(@"C:\foo\teste.txt", FileMode.Create); // cria e abre o arquivo primeiro
            try
            {
                // body - executa seu código
            }
            finally
            {
                f.Dispose(); // fecha o arquivo
            }

            // com syntatic sugar
            using (FileStream  f2 = new FileStream(@"C:\teste.txt", FileMode.Create)) 
            {
                // body
            }

            // using faz com que seu arquivo seja aberto e depois que todas as linhas do body são processadas, seu arquivo fecha automaticamente
        }
    }
}