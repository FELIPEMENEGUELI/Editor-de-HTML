namespace EditHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            //mudando a cor de fundo do console
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            //mudando a cor da letra do console
            Console.ForegroundColor = ConsoleColor.White;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine()!);
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {
            //usamos esse metodod para indicarmos onde o curso deve começar, primeiro declaramos a coluna, depois a linha
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Console.WriteLine("Editor"); break;
                case 2: Console.WriteLine("Visualizar"); break;
                case 3:
                    {
                        Console.Clear();
                        Environment.Exit(0); break;
                    }
                default: Show(); break;
            }
        }
    }
}