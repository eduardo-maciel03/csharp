namespace DigiBank.Classes
{
    public class Layout // aqui acontece todas as etapas do projeto
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White; // alterando as cores do console

            Console.Clear(); // .Clear() limpa o console

            Console.WriteLine("                                                       ");
            Console.WriteLine("               Digite a opção desejada :               ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               1 - Criar Conta                         ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               2 - Entrar com CPF e Senha              ");
            Console.WriteLine("              ================================         ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break; 
                case 2:
                    TelaDeLogin();
                    break;
                default: 
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        private static void TelaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                                                       ");
            Console.WriteLine("               Digite seu nome:                        ");
            string nome = Console.ReadLine();
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               Digite seu CPF:                         ");
            string cpf = Console.ReadLine();
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               Digite sua senha:                       ");
            string senha = Console.ReadLine();
            Console.WriteLine("              ================================         ");

            ContaCorrente contaCorrente = new ContaCorrente();
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente;

            pessoas.Add(pessoa);

            Console.Clear();

            Console.WriteLine("                                                       ");
            Console.WriteLine("               Conta cadastrada com sucesso!           ");
            Console.WriteLine("              ================================         ");

            Thread.Sleep(2000); // congelando o console por 2 segundos. Esse método Sleep recebe o tempo em milissegundos

            TelaContaLogada(pessoa);

        }

        private static void TelaDeLogin()
        {
            Console.Clear();

            Console.WriteLine("                                                       ");
            Console.WriteLine("               Digite seu CPF:                         ");
            string cpf = Console.ReadLine();
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               Digite sua senha:                       ");
            string senha = Console.ReadLine();
            Console.WriteLine("              ================================         ");

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha); // expressão lambda, retorna o primeiro elemento que satisfaz a condição, ou um valor default

            if(pessoa != null)
            {
                TelaBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();

                Console.WriteLine("                                                       ");
                Console.WriteLine("               Conta não cadastrada!                   ");
                Console.WriteLine("              ================================         ");

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void TelaBoasVindas(Pessoa pessoa) 
        {
            string msgTelaBoasVindas = 
                $"{pessoa.Nome} | Banco: {pessoa.Conta.GetCodigoDoBanco()} | Agência {pessoa.Conta.GetNumeroAgencia()} | Conta: {pessoa.Conta.GetNumeroConta()}";

            Console.WriteLine("");
            Console.WriteLine($"  Seja bem vindo! {msgTelaBoasVindas}  ");
            Console.WriteLine("");
        }
        
        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("               Digite uma operação:                    ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               1 - Depósito                            ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               2 - Saque                               ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               3 - Consultar Saldo                     ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               4 - Extrato                             ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               5 - Sair                                ");
            Console.WriteLine("              ================================         ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaConsultaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
                    break;
                case 5:
                    TelaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("               Opção Inválida!                         ");
                    Console.WriteLine("              ================================         ");
                    break;

            }
        }

        private static void TelaDeposito(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("               Digite o valor a depositar:             ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("              ================================         ");

            pessoa.Conta.Deposita(valor);

            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");
            Console.WriteLine("               Depósito realizado!                     ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");

            TelaVoltarLogado(pessoa);
            
        }

        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("               Digite o valor a sacar:                 ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("              ================================         ");

            bool confirma = pessoa.Conta.Sacar(valor);


            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");

            if (confirma)
            {
                Console.WriteLine("               Saque realizado!                        ");
                Console.WriteLine("              ================================         ");
            }
            else
            {
                Console.WriteLine("               Saldo Insuficiente!                     ");
                Console.WriteLine("              ================================         ");
            }
            Console.WriteLine("                                                       ");
            Console.WriteLine("                                                       ");

            TelaVoltarLogado(pessoa);

        }

        private static void TelaConsultaSaldo(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            Console.WriteLine($"               Saldo atual: {pessoa.Conta.ConsultaSaldo()}  ");
            Console.WriteLine("              ================================               ");
            Console.WriteLine("                                                             ");

            TelaVoltarLogado(pessoa);
        }

        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();
            TelaBoasVindas(pessoa);

            if (pessoa.Conta.GetExtratoList().Any())
            {
                double total = pessoa.Conta.GetExtratoList().Sum(x => x.Valor);

                foreach (Extrato extrato in pessoa.Conta.GetExtratoList())
                {
                    Console.WriteLine("                                                                       ");
                    Console.WriteLine($"               Data: {extrato.Data.ToString("dd/MM/yyyy  HH:mm:ss")}  ");
                    Console.WriteLine($"               Tipo de movimentação: {extrato.Descricao}              ");
                    Console.WriteLine($"               Valor: {extrato.Valor}                                 ");
                    Console.WriteLine("              ================================                         ");
                }

                Console.WriteLine("                                                       ");
                Console.WriteLine("                                                       ");
                Console.WriteLine($"               SUB TOTAL: {total}                     ");
                Console.WriteLine("              ================================         ");
                Console.WriteLine("                                                       ");

                TelaVoltarLogado(pessoa);
            }
            else
            {
                Console.WriteLine("               Não há extrato!                              ");
                Console.WriteLine("              ================================              ");


                TelaVoltarLogado(pessoa);
            }
        }

        private static void TelaVoltarLogado(Pessoa pessoa)
        {
            Console.WriteLine("               Escolha uma opção abaixo                ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               1 - Voltar para minha conta             ");
            Console.WriteLine("              ================================         ");
            Console.WriteLine("               2 - Sair                                ");
            Console.WriteLine("              ================================         ");

            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                TelaContaLogada(pessoa);
            }
            else
            {
                TelaPrincipal();
            }
        }

    }
}
