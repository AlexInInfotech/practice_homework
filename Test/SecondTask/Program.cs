using System.Text;

internal class Program
{
    public static string Encode(string str)
    {
        int code;
        string newstroke = "";
        for (int i = 0; i < str.Length; i++)
        {
            code = (int)str[i] + 2;
            newstroke += (char)code;
        }
        return newstroke.ToString();
    }

    public static string Decode(string str)
    {
        int code;
        string newstroke = "";
        for (int i = 0; i < str.Length; i++)
        {
            code = (int)str[i] - 2;
            newstroke += (char)code;
        }
        return newstroke.ToString();
    }

    private static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string stroke = Console.ReadLine();
        stroke = Encode(stroke);
        Console.WriteLine("Закодированная строка: " + stroke);
        stroke = Decode(stroke);
        Console.WriteLine("Раскодированная строка: " + stroke);
    }
}
