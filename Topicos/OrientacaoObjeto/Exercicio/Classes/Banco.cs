namespace DigiBank.Classes
{
    public abstract class Banco // uma classe abstrada não permite que você instancie um objeto dela, mas você pode herdar ela, e acessar seus métodos e atributos
    {
        public Banco()
        {
            this.NomeDoBanco = "DigiBank";
            this.CodigoDoBanco = "042";
        }

        public string NomeDoBanco { get; private set; } 
        public string CodigoDoBanco { get; private set; }

        // get e set. O método Get retorna o atributo, pode estar publico, já o método Set, para definir o valor do atributo, devem ser private ou protected, para que apenas classes permitidas o acessem
    }
}
