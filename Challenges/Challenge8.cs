namespace MoureDevWeeklyChallenge.Challenges;

public class Challenge8
{

    public static void exe(int number)
    {
        int aux = number;
        int sobrante = 0;
        List<string> list = new();
        string? binaryResult = null;
            while(number!=0)
            {
                sobrante = number % 2;
                number = number / 2;
                list.Add(sobrante.ToString());
            }
                
        Console.WriteLine("Decimal\tBinary");
        Console.Write(aux+"\t");

        list.Reverse();
        foreach (string str in list) 
            Console.Write(str);

        Console.WriteLine();
    }
}
