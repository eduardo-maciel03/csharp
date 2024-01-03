// GUID - (Globally Unique Identifier) identificador único global, é um número pseudoaleatorio, um número inteiro
// de 128 bits que pode ser usado em todos os computadores e redes, onde você precisar de um identificador
// exclusivo. A probabilidade do número gerado ser duplicado é muito baixa.

// como os GUIDs possuem 128 bits , podemos gerar até 2^128 GUIDs 
// ou algo em torno de 5.316.911.983.139.663.491.615.228.241.121.400.000 combinações possíveis.
// E para gerar GUIDs no .NET Core usamos a struct GUID disponível no namespace 
// System no assembly System.Runtime.dll.

// sua construção é composta por blocos de 8-4-4-4-12
// ex: 50b97e45-526c-4a8d-bddf-2d82e2f1b669

namespace CSharp
{
    public static Guid exemploGuid()
    {
        // exemplo: 
        Guid g = Guid.NewGuid();
        return g;
    }
}