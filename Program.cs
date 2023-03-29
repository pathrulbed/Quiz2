public class Program
{
    static string InputGender()
    {
        Console.WriteLine("Input Gender:");
        return Console.ReadLine();
    }
    static string InputNumber()
    {
        Console.WriteLine("Input Number:");
        return Console.ReadLine();
    }
    static string InputScore()
    {
        Console.WriteLine("Input score:");
        return Console.ReadLine();
    }

    static void Main(string[] args)
    {
        int P_num = int.Parse(Console.ReadLine());
        int J_num = int.Parse(Console.ReadLine());
        int MJ= J_num; int FJ = J_num;
        for (int i = 1; i <= P_num; i++)
        {
            int Gender = int.Parse(InputGender());
            string Number = InputNumber();
            int score = int.Parse(InputScore());
            while (MJ > 0 && FJ > 0)
            {
                if (MJ > 0 && score >= 9)
                {
                    if (Gender == 1)
                    { 
                        Console.WriteLine("1 {1}",Number);
                        MJ--;
                    }
                    else if (Gender == 2 && FJ >0)
                    {
                        Console.WriteLine("2 {1}",Number);
                        FJ--;
                    }
                }
                
            }
        } 
    }
    
}
