using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
            public class Program
        {
            public static void Main(string[] args)
            {
               int num = 9;
               int fact = 1;

               for (int i = 1; i <= num; i++)
               {
                fact = fact * i;
               }
               Console.WriteLine(fact);
        }
    }
}