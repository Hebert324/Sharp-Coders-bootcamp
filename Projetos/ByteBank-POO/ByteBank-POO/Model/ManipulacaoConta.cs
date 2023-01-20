using BytebankPOO.Model;
using BytebankPOO.View;

namespace ByteBank_POO.Model
{

    public class ManipulacaoConta
    {
        public static void ManipularConta(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int index)
        {
            int option;
            TextoColorido.MudarCorTexto(ConsoleColor.Cyan, "Menu de manipulção da conta");

            do
            {
                MenuView.ShowMenuManipularConta();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        TextoColorido.MudarCorTexto(ConsoleColor.Red, "Voltando ao Menu Principal!");
                        break;
                    case 1:
                        Conta.Deposito(cpfs, titulares, senhas, saldos, index);
                        break;
                    case 2:
                        Conta.Saque(cpfs, titulares, senhas, saldos, index);
                        break;
                    case 3:
                        Conta.Transferencia(cpfs, titulares, senhas, saldos, index);
                        break;
                    case 4:
                        Conta.SaldoTotal(saldos, index);
                        break;
                }

            } while (option != 0);
        }
    }
}
