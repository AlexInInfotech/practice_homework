internal class FirstTask
{
    
    private static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();

        Console.Write("Сколько чисел вы хотите ввести: ");
        int.TryParse(Console.ReadLine(), out int length);
        int temp;
        int RealNumLength = length;
        Console.WriteLine("Вводите: ");

        for (int i = 0; i < length; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
            }
            else
            {
                RealNumLength--;
            }
        }
        for (int j = 1; j < RealNumLength; j++)
        {
            for (int i = 0; i < RealNumLength - j; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    temp = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }

        Console.WriteLine("Отсортированный список: ");

        for (int i = 0; i < RealNumLength; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
