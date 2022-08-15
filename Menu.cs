namespace EditorHtml;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        DrawScreen(30);
        WriteOptions();

        var option = short.Parse(Console.ReadLine()!);
        HandleMenuOption(option);
    }

    public static void DrawScreen(int columns)
    {
        Line(columns);

        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= columns; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Line(columns);
    }

    private static void Line(int columns)
    {
        Console.Write("+");
        for (int i = 0; i <= columns; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write("\n");
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor Html");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("----------------------");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Select an option below");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - New File");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Open File");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Exit");
        Console.SetCursorPosition(3, 11);
        Console.Write("Option: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1:
                Editor.Show();
                break;
            case 2:
                break;
            case 0:
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Show();
                break;
        }
    }
}