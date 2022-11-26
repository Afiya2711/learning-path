using System; 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,a;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (a = 1; a <= num; a++)
            {
                if (num % a == 0)
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadLine();
 
        }
    }
}
