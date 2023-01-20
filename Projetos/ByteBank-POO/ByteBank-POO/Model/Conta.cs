using BytebankPOO.View;

namespace BytebankPOO.Model
{
    public class Conta
    {
        public static void Deposito(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            int indexParaDepositar = indexParaApresentar;

            if (indexParaDepositar == -1)
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, "Conta não encontrada!");
            }
            else
            {
                Console.Write("Digite o valor do deposito: ");
                double valorParaDeposito = double.Parse(Console.ReadLine());

                saldos[indexParaDepositar] += valorParaDeposito;

                TextoColorido.MudarCorTexto(ConsoleColor.Green, $"Deposito de: R${valorParaDeposito} realizado com sucesso!");
            }
        }
        public static void Saque(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            Console.Write("Digite a SENHA para prosseguir com o Saque: ");
            string senhaParaPesquisar = Console.ReadLine();

            int indexParaSaquar = indexParaApresentar;

            if (senhas[indexParaSaquar] == senhaParaPesquisar)
            {
                Console.Write("Digite o valor para Saquar: ");
                double valorParaSaque = double.Parse(Console.ReadLine());
                saldos[indexParaSaquar] -= valorParaSaque;

                TextoColorido.MudarCorTexto(ConsoleColor.Green, $"Saque de: R${valorParaSaque} realizado com sucesso!");
            }
            else
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, $"Não foi possivel realizar o Saque: Senha errada!");
            }
        }

        public static void Transferencia(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
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
                    TextoColorido.MudarCorTexto(ConsoleColor.Green, $"Conta do {titulares[indexParaTransferirDinheiro]} encontrada! | Seu Saldo para transferência e: R${saldos[indexParaTransferir]}");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Quanto deseja transferir para {titulares[indexParaTransferirDinheiro]} :");
                    double valorDeTransferencia = double.Parse(Console.ReadLine());

                    if (valorDeTransferencia == 0)
                    {
                        TextoColorido.MudarCorTexto(ConsoleColor.Red, "Transferência indisponivel, insira um valor maior que R$ 1,00");
                    }
                    else
                    {
                        saldos[indexParaTransferirDinheiro] += valorDeTransferencia;
                        saldos[indexParaTransferir] -= valorDeTransferencia;

                        TextoColorido.MudarCorTexto(ConsoleColor.Red, $"Transferência de: R${valorDeTransferencia} realizado com sucesso para a conta {titulares[indexParaTransferirDinheiro]}!");
                    }
                }
            }
            else
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, $"Não foi possivel realizar a Transferencia: Senha errada!");
            }
        }

        public static void SaldoTotal(List<double> saldos, int indexParaApresentar)
        {
            int indexParaPesquisar = indexParaApresentar;

            if (indexParaPesquisar == -1)
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, "Erro: Conta não encontrada!");
            }
            else
            {
                double totalSaldo = saldos[indexParaPesquisar];

                TextoColorido.MudarCorTexto(ConsoleColor.Green, $"Total do Saldo na sua conta: R${totalSaldo}");
            }
        }


        public static void Apresentar(int i, List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            TextoColorido.MudarCorTexto(ConsoleColor.Green, $"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
        }

        public static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                Apresentar(i, cpfs, titulares, saldos);
            }
        }

        public static void ApresentarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos, int indexParaApresentar)
        {
            if (indexParaApresentar == -1)
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, "Conta não encontrada!");
            }
            else
            {
                Apresentar(indexParaApresentar, cpfs, titulares, saldos);
            }
        }


    }
}
