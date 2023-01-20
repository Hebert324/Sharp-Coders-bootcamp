namespace BytebankPOO.Model
{
    public class TextoColorido
    {
        // Métodos
        public static void MudarCorTexto(ConsoleColor cor, string texto)
        {
            Console.ForegroundColor = cor;

            Console.WriteLine("");
            Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

            Console.Write(texto);

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
            Console.WriteLine("");

            Console.ResetColor();

            // Declaração para o Mudar a cor do texto: MudatCorTexto(ConsoleColor.Green, "Hello World!");
        }

        public static void MudatCorDoBackground(ConsoleColor corText, ConsoleColor corBg, string texto)
        {
            Console.ForegroundColor = corText;
            Console.BackgroundColor = corBg;

            Console.WriteLine("");
            Console.Write(String.Concat(Enumerable.Repeat("-", 15)));

            System.Console.Write(texto);

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 15)));
            Console.WriteLine("");

            Console.ResetColor();

            // Declaração para o Mudar a cor do texto: MudatCorDoBackground(ConsoleColor.White, ConsoleColor.DarkCyan, "Hello World!");
        }
    }
}
