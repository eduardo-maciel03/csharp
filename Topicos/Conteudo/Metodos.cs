namespace CSharp
{
    public class Metodos
    {
        // A Classe Task permite que trabalhemos operações de forma assíncrona
        public async Task Aprendizados() // async await - programação assíncrona
        {
            // método delegado (delegate) encapsula com segurança um método, semelhante a um ponteiro de função, serve para facilitar suas operações
            Run(Multiply);
            Run(Sum);

            var multiply = (int x, int y) => x * y;
            Run(multiply);

            // LINQ Consulta integrada na linguagem (Language integrated query)
            int[] numbers = { 1, 5, 12, 14 };

            // query na mão
            var query = from number in numbers
                        where number < 10
                        select number;

            // query com método Where
            var query2 = numbers.Where(number => number < 10); // Where acha os elementos exatos que satisfazem a condição

            foreach (var item in query2)
            {
               Console.WriteLine(item);
            }


            Console.WriteLine("Executando");

            var task = Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Acordou...");
                return "Eduardo";
            });

            var result = await task; 
            // await faz a execução de um método async pausar, para esperar pelo retorno da Promise, e volta a execução quando o valor da Promise é resolvido

            Console.WriteLine("Pronto");
            Console.WriteLine(result);
        }

        // você pode usar esse delegado para representar um método que pode ser passado como um parâmetro. O método encapsulado deve corresponder à assinatura do método definida por esse delegado
        public static void Run(Func<int, int ,int> calc) 
        {
           Console.WriteLine(calc(2,3)); // chamando os métodos abaixo Sum (soma 2 + 3) e Multiply (multiplica 2 * 3)
        }

        public static int Sum(int a, int b)
        {
           return a + b;
        }

        public static int Multiply(int a, int b)
        {
           return a * b;
        }
    }

    delegate int Calculator(int x, int y);

}