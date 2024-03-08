using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    namespace Client
    {
        public class Program
        {
            static void Great(string name)
            {
                Console.WriteLine("HARRY POTTER"+ name);
            }
            public static void Main(string[] args)
            {
                Console.WriteLine("Hello");
        Great(" Wizard");
        Great(" Magician");
            }
        }
    }
