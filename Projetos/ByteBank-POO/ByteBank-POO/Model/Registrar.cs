using BytebankPOO.Model;

namespace BytebankPOO.Model
{
    public class RegistrarNovoUsuario
    {
        public static void Registrar(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            TextoColorido.MudarCorTexto(ConsoleColor.Cyan, "Registrando Usuário");

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (!cpfs.Contains(cpf))
            {
                cpfs.Add(cpf);

                Console.Write("Digite o nome: ");
                titulares.Add(Console.ReadLine());

                Console.Write("Insira sua senha: ");
                senhas.Add(Console.ReadLine());

                saldos.Add(0);

                TextoColorido.MudarCorTexto(ConsoleColor.Cyan, "Usuário Cadastrado com sucesso!");
            }
            else
            {
                TextoColorido.MudarCorTexto(ConsoleColor.Red, "CPF já já cadastrado tente outro!");
            }
        }
    }
}
