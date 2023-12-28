//dotnet new console - cria novo projeto de console C#
//dotnet run - roda a aplicação


// VARIÁVEIS
string texto = "Olá"; // textos
char character = 'e'; // um caractere
int inteiro = 5; // número inteiro
long longo = 10; // aceita números maiores que o tipo int
float num1 = 1.20f; // números com decimais menores, sem grande precisão
double num2 = 1.55; // números com decimais maiores, é mais preciso e aceita um número maior que o tipo float
decimal num3 = 1.10m; // números com decimais exatos grandes e mais precisos, usado para cálculos financeiros
bool booleana = true; // aceita apenas dois valores, true (1) ou false (0)


// PRINTS
Console.WriteLine("Hello, World!"); // escreve algo no console
Console.WriteLine(510);
Console.WriteLine(inteiro);
Console.WriteLine("Hello," + "World!"); // concatenação
Console.WriteLine($"{texto} mundo!"); // interpolação


// MANIPULANDO STRINGS
var variavel = "Janeiro";
Console.WriteLine($"{variavel}\nFevereiro\nMarço"); // "\n" quebra a linha
Console.WriteLine(variavel.Length); // retorna a quantidade de caracteres da string
variavel.ToLower(); // deixa toda a string em minúsculo
variavel.ToUpper(); // deixa toda a string em maiúsculo
variavel.StartsWith("j"); // verifica se a string começa com a letra específica


// CONVERSÃO DE VARIÁVEIS (CASTING)
double cast = (double)inteiro;
Console.WriteLine(Convert.ToString(inteiro)); // métodos para converter
string numero = "1";
Console.WriteLine(int.Parse(numero)); // convertendo o valor para int


// OPERADORES ARITMÉTICOS 
double adicao = 5 + 5;
double subtracao = 10 - 5;
double multiplicacao = 10 * 10;
double divisao = 12 / 3;
double resto = 50 % 2;
// += mais igual
// -= menos igual
// *= vezes igual
// /= dividido igual
// %= modulo igual

// OPERADORES RELACIONAIS
// == igual a
// != diferente de
// > maior que
// < menor que
// >= maior igual
// <= menor igual

// OPERADORES LÓGICOS
// && and = e
// || or = ou
// ! not = não (negação)


// IF ELSE
if(num1 < num2){
    Console.WriteLine(":)");
}else{
    Console.WriteLine(":/");
}

if(adicao == 10){

}else if(adicao != 15){

}

if(num1 == 1 && num2 == 5){

}


// OPERADORES TERNÁRIOS 
int n = 10;
var opTernario = n == 10 ? "é igual" : "não é igual";


// SWITCH CASE
Console.WriteLine("Deseja entrar no sistema?");
var resposta = Console.ReadLine(); // método que armazena oque o usuário digitou no console

switch(resposta){
    case "Sim":
        Console.WriteLine("Entrou");
        break;
    case "Não":
        Console.WriteLine("Não entrou");
        break;
    default:
        Console.WriteLine("Reposta inválida");
        break;
}


// LISTAS E ARRAYS
List<string> nomes = new List<string>(){"Maria", "Fernando", "João"}; // pode iniciar os valores desejados
List<string> sobrenomes = new List<string>(5); // define o máximo de strings na lista

string[] livros = {"Harry Potter", "C# guia prático"};
int[] array = new int[5];

//a diferença entre lista e array, é que na lista você poderá alterar o conteúdo dela futuramente, ela possui um comprimento variável, 
//array possui um conteúdo já pré-definido, ex:
nomes.Add("Joana"); // adiciona um novo item
nomes.Remove("Fernando"); // remove o item escrito
nomes.Clear(); // limpa a lista
nomes.Contains("Maria"); // retorna se contém ou não o item

Console.WriteLine(nomes[0] + livros[1]); // pode acessar qualquer um deles pelo índice


// LOOPINGS
int loop = 5;

for(int i = 0; i <= 5; i++){ // executa até que seja possível, oque foi setado
    Console.WriteLine(i); // a variável i vai até ao número 5
}

while(loop == 10){ // executa uma ação enquanto a condição for verdadeira
    Console.WriteLine(loop);
    loop++;
}

do{
    Console.WriteLine(loop);
    loop++;
}while(loop == 10); // primeiro executa a ação e depois verifica se a condição é verdadeira

foreach(var nome in nomes){ // percorre listas e arrays
    Console.WriteLine(nome);
}

