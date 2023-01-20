using System.Globalization;

namespace ByteBank
{
    public class Program
    {
        static void ShowMenuLogin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - Criar novo Conta");
            Console.WriteLine("2 - Fazer Login na Conta");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("0 - Sair do programa");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");
            Console.WriteLine("");
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - Detalhes de um usuário");
            Console.WriteLine("2 - Realizar: Depositos, Saques e Transferências");
            Console.WriteLine("3 - Deletar sua Conta");
            Console.WriteLine("4 - Listar todas as contas registradas");
            Console.WriteLine("5 - Quantia total armazenada no banco");
            Console.WriteLine("0 - Sair da conta");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");
            Console.WriteLine("");
        }

        static void ShowMenuManipularConta()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - Fazer Deposito");
            Console.WriteLine("2 - Fazer Saque");
            Console.WriteLine("3 - Fazer Transferência");
            Console.WriteLine("4 - Verificar Saldo da Conta");
            Console.WriteLine("0 - Voltar para Menu Principal");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Write("Digite a opção desejada: ");
            Console.WriteLine("");
        }

        static void WriteTextFormatedAndColor(string txt, string color)
        {
            if (color == "Red" || color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("");
                Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

                Console.Write(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Green" || color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                System.Console.WriteLine(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Green2" || color == "green2")
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                System.Console.WriteLine(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Background" || color == "background")
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

                System.Console.Write(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
                Console.WriteLine("");

                Console.ResetColor();
            }
            else if (color == "Cyan" || color == "cyan")
            {

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("");
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                System.Console.WriteLine(txt);

                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));
                Console.WriteLine("");

                Console.ResetColor();
            }
        }

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            WriteTextFormatedAndColor("Registrando Usuário", "Cyan");

            Console.Write("Digite o CPF: ");
            cpfs.Add(Console.ReadLine());

            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());

            Console.Write("Insira sua senha: ");
            senhas.Add(Console.ReadLine());

            saldos.Add(0);

            WriteTextFormatedAndColor("Usuário cadastrado com sucesso!", "Green");
        }

        static void LoginNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int option)
        {
            WriteTextFormatedAndColor("Faça Login na sua conta", "Cyan");

            Console.Write("Digite o seu CPF: ");
            string cpfParaPesquisar = Console.ReadLine();

            Console.Write("Digite a SENHA entrar na conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaApresentar = cpfs.FindIndex(d => d == cpfParaPesquisar);
            int logoutOption = 1;

            if (senhas[indexParaApresentar] == senhaParaPesquisar)
            {
                WriteTextFormatedAndColor("Login realizado com Sucesso!", "Green");

                string logout = "";

                // Menu do usuario logado
                do
                {
                    ShowMenu();
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            WriteTextFormatedAndColor("Você saiu da Conta!", "Red");
                            break;
                        case 1:
                            ApresentarUsuario(cpfs, titulares, senhas, saldos, indexParaApresentar);
                            break;
                        case 2:
                            ManipularConta(cpfs, titulares, senhas, saldos, indexParaApresentar);
                            break;
                        case 3:
                            DeletarUsuario(cpfs, titulares, senhas, saldos, indexParaApresentar);
                            break;
                        case 4:
                            ListarTodasAsContas(cpfs, titulares, saldos);
                            break;
                        case 5:
                            ApresentarSomaTotal(saldos);
                            break;
                    }

                } while (option != 0);
            }
            else
            {
                WriteTextFormatedAndColor("Erro: Conta não encontrada ou Senha Errada!", "Red");
            }
        }

        static void DeletarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int index)
        {
            Console.Write("Digite a SENHA para deletar a Conta: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaDeletar = index;

            if (senhas[indexParaDeletar] == senhaParaPesquisar)
            {
                // Deletando o CPF e as informações
                cpfs.RemoveAt(indexParaDeletar);
                senhas.RemoveAt(indexParaDeletar);
                titulares.RemoveAt(indexParaDeletar);
                saldos.RemoveAt(indexParaDeletar);

                WriteTextFormatedAndColor("Conta deletada com sucesso!", "Green");
                WriteTextFormatedAndColor("SUA CONTA NÃO EXISTE MAIS, APERTE 0 PARA SAIR!!!!!!", "Red");
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel deletar a conta: Senha Errada!", "Red");
            }
        }

        static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            if (indexParaApresentar == -1)
            {
                WriteTextFormatedAndColor("Erro: Conta não encontrada!", "Red");
            }
            else
            {
                ApresentaConta(indexParaApresentar, cpfs, titulares, saldos);
            }
        }

        static void ManipularConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            int option;

            WriteTextFormatedAndColor("Menu de manipulção da conta", "Cyan");

            do
            {
                ShowMenuManipularConta();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        WriteTextFormatedAndColor("Voltando ao Menu Principal!", "Red");
                        break;
                    case 1:
                        DepositoNaConta(cpfs, titulares, senhas, saldos, indexParaApresentar);
                        break;
                    case 2:
                        SaqueNaConta(cpfs, titulares, senhas, saldos, indexParaApresentar);
                        break;
                    case 3:
                        TransferenciaNaConta(cpfs, titulares, senhas, saldos, indexParaApresentar);
                        break;
                    case 4:
                        SaldoTotalDaConta(cpfs, titulares, senhas, saldos, indexParaApresentar);
                        break;
                }

            } while (option != 0);
        }

        static void DepositoNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            int indexParaDepositar = indexParaApresentar;

            if (indexParaDepositar == -1)
            {
                WriteTextFormatedAndColor("Erro: Conta não encontrada!", "Red");
            }
            else
            {
                Console.Write("Digite o valor do deposito: ");
                double valorParaDeposito = double.Parse(Console.ReadLine());

                saldos[indexParaDepositar] += valorParaDeposito;

                WriteTextFormatedAndColor($"Deposito de: R${valorParaDeposito} realizado com sucesso!", "Green");
            }
        }

        static void SaqueNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            Console.Write("Digite a SENHA para prosseguir com o Saque: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaSaquar = indexParaApresentar;

            if (senhas[indexParaSaquar] == senhaParaPesquisar)
            {
                Console.Write("Digite o valor para Saquar: ");
                double valorParaSaque = double.Parse(Console.ReadLine());
                saldos[indexParaSaquar] -= valorParaSaque;

                WriteTextFormatedAndColor($"Saque de: R${valorParaSaque} realizado com sucesso!", "Green");
            }
            else
            {
                WriteTextFormatedAndColor("Não foi possivel realizar o Saque: Senha errada!", "Red");
            }
        }

        static void TransferenciaNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            Console.Write("Digite a SENHA para prosseguir com a transferência: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaTransferir = indexParaApresentar;

            if (senhas[indexParaTransferir] == senhaParaPesquisar)
            {
                Console.Write("Informe o CPF da conta que quer transferir: ");
                string cpfParaTranferir = Console.ReadLine();

                int indexParaTransferirDinheiro = cpfs.FindIndex(d => d == cpfParaTranferir);

                if (cpfs[indexParaTransferirDinheiro] == cpfParaTranferir)
                {
                    WriteTextFormatedAndColor($"Conta do {titulares[indexParaTransferirDinheiro]} encontrada! | Seu Saldo para transferência e: R${saldos[indexParaTransferir]}", "Green");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Quanto deseja transferir para {titulares[indexParaTransferirDinheiro]} :");
                    double valorDeTransferencia = double.Parse(Console.ReadLine());

                    if (valorDeTransferencia == 0)
                    {
                        WriteTextFormatedAndColor("Transferência indisponivel, insira um valor maior que R$ 1,00", "Red");
                    }
                    else
                    {
                        saldos[indexParaTransferirDinheiro] += valorDeTransferencia;
                        saldos[indexParaTransferir] -= valorDeTransferencia;

                        WriteTextFormatedAndColor($"Transferência de: R${valorDeTransferencia} realizado com sucesso para a conta {titulares[indexParaTransferirDinheiro]}!", "Green");
                    }
                }
            }
            else
            {
                WriteTextFormatedAndColor("Erro: Senha Errada!", "Red");
            }
        }

        static void SaldoTotalDaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            int indexParaPesquisar = indexParaApresentar;

            if (indexParaPesquisar == -1)
            {
                WriteTextFormatedAndColor("Erro: Conta não encontrada!", "Red");
            }
            else
            {
                double totalSaldo = saldos[indexParaPesquisar];

                WriteTextFormatedAndColor($"Total do Saldo na sua conta: R${totalSaldo}", "Green");
            }
        }

        static void ApresentaConta(int i, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            WriteTextFormatedAndColor($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}", "Green2");
        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                ApresentaConta(i, cpfs, titulares, saldos);
            }
        }

        static void ApresentarSomaTotal(List<double> saldos)
        {
            WriteTextFormatedAndColor($"Total acumulado no banco: R${saldos.Sum()}", "Green");

            // saldos.Sum(); ou .Aggregate(0.0, (x, y) => x + y);
        }

        public static void Main(string[] args)
        {
            WriteTextFormatedAndColor("Bem Vindo ao Byte Bank o mais rápido e seguro!", "background");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            do
            {
                ShowMenuLogin();
                option = int.Parse(Console.ReadLine());


                switch (option)
                {
                    case 0:
                        WriteTextFormatedAndColor("Programa Encerrado!", "Red");
                        break;
                    case 1:
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        LoginNaConta(cpfs, titulares, senhas, saldos, option);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                }

            } while (option != 0);


        }

    }

}