namespace BytebankPOO.View
{
    public static class MenuView
    {
        public static void ShowMenuPrincipal()
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
        public static void ShowMenuLogin()
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


        public static void ShowMenuManipularConta()
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
    }
}
