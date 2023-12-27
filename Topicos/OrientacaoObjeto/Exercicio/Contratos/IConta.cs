using DigiBank.Classes;

namespace DigiBank.Contratos
{
    public interface IConta // interface, serve como um contrato, onde as classes que implementarem essa interface, devem sobrepor seus métodos. Interfaces não possuem atributos
    { 

        void Deposita(double valor);

        bool Sacar(double valor);

        double ConsultaSaldo();

        string GetCodigoDoBanco();

        string GetNumeroAgencia();

        string GetNumeroConta();

        List<Extrato> GetExtratoList();

    }
}
