using BytebankPOO.View;
using BytebankPOO.Model;
using ByteBank_POO.Model;

namespace BytebankPOO.Model
{
    public class Login
    {
        public static void LoginNaConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int option)
        {
            TextoColorido.MudarCorTexto(ConsoleColor.Cyan, "Faça Login na sua conta");

            Console.Write("Digite o seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite a SENHA entrar na conta: ");
            string senha = Console.ReadLine();

            int index = cpfs.FindIndex(d => d == cpf);

            if (senhas[index] == senha)
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Green, "Login realizado com Sucesso!");

                // Menu do usuario logado
                do
                {
                    MenuView.ShowMenuPrincipal();
                    option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            TextoColorido.MudarCorTexto(ConsoleColor.Red, "Você saiu da Conta!");
                            break;
                        case 1:
                            Conta.ApresentarUsuario(cpfs, titulares, senhas, saldos, index);
                            break;
                        case 2:
                            ManipulacaoConta.ManipularConta(cpfs, titulares, senhas, saldos, index);
                            break;
                        case 3:
                            //DeletarUsuario(cpfs, titulares, senhas, saldos, index);
                            break;
                        case 4:
                            Conta.ListarTodasAsContas(cpfs, titulares, saldos);
                            break;
                        case 5:
                            Conta.SaldoTotal(saldos, index);
                            break;
                    }

                } while (option != 0);
            }
            else
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, "Conta não encontrada ou Senha Errada!");
            }
        }
    }
}
