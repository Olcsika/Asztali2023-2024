using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_feldat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter iras = new StreamWriter("ize.txt");

            while (true)
            {
                
                Console.WriteLine("Kérek egy számot");
                int szam = Convert.ToInt32(Console.ReadLine());
                iras.WriteLine(szam+" "+szam*szam);
                if (szam == 0) 
                {
                    break;
                    
                }
                

            }
            iras.Close();
        }
    }
}
