using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODE EDITOR");
        Console.WriteLine("-----------------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-----------------");

        Viewer.Show(file.ToString());

        string res;
        do
        {
            Console.WriteLine("Do you want to save the file? - YES / NO");
            res = (Console.ReadLine()!.ToLower());
        } while (!res.Equals("yes") && !res.Equals("no"));

        if (res.Equals("no"))
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Menu.Show();
        }

        Save(file);
    }

    public static void Save(StringBuilder fileEdited)
    {
        Console.Clear();
        Console.WriteLine("What is the path to save the file?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path!))
        {
            file.Write(fileEdited);
        }

        Console.WriteLine($"File {path} saved successfully");
        Console.ReadLine();
        Console.BackgroundColor = ConsoleColor.Black;
        Menu.Show();
    }
}