namespace CSharp
{
    public class Genericos
    {
        public void Aprendizados()
        {
            // Tópico Generics
            String[] stringArray = new String[] { "Eduardo", "Luiz", "Juca" };
            int[] intArray = new int[] { 1, 2, 3};
            double[] doubleArray = new double[] { 1.0, 2.0, 3.0 };

            ArrayReader(stringArray);
            ArrayReader(intArray);
            ArrayReader(doubleArray);

            // Tópico Dictionary, chave - valor
            Dictionary<int, String> myDictionary = new Dictionary<int, String>
            {
                { 1, "Eduardo" },
                { 2, "Luiz" },
                { 3, "Juca" }
            };

            // operador ternário, ContainsKey verifica se contém ou não a chave no Dictionary
            var condition = myDictionary.ContainsKey(4) ? "Ok" : "Não";
            Console.WriteLine(condition);

            if (myDictionary.ContainsKey(1)) 
            {
                Console.WriteLine("Certo");
            }
            else
            {
                Console.WriteLine("Errado");
            }

        }

        // método genérico, recebe uma array de qualquer tipo e retorna diferentes tipos de valores
        public static void ArrayReader<Thing>(Thing[] array)
        {
            foreach (Thing thing in array) 
            {
                Console.WriteLine(thing);
            }
        }

    }

    public class ListaGenerica<TIPO>
    {
        public ListaGenerica() 
        {
            MinhaLista = new List<TIPO>();
        }

        public List<TIPO> MinhaLista { get; set; }
    }
}