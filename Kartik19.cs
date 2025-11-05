using system;
namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Writeline("Enter the value of a and b ");
            a = Convert.Toint32(Console.ReadLine());
            b = Convert.Toint32(Console.ReadLine());
            int sum = a + b;
            Console.Writeline("The sum of a and b is : {0}+{1} = {2}", a, b, sum);
            Console.ReadLine();
        }
    }
}
