using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolKrista
{
    class Program
    {
        static void Main(string[] args)
        {
            LogikModel logikModel = new LogikModel();

            String nameProgram = "";
            Boolean flag = true;
            while (flag)
            {
                switch (nameProgram)
                {
                    case "":
                        Console.Write("Write name of program which you will started: \n>> ");
                        
                        nameProgram = Console.ReadLine();
                        break;
                    
                    case "ConsolKrista Calculations":
                        logikModel.start();
                        nameProgram = "";
                        break;
                   
                    case "Exit":
                        System.Environment.Exit(0);
                        break;

                    case "exit":
                        System.Environment.Exit(0);
                        break;
                    
                    default:
                        Console.WriteLine("Error colled, please, check name of program!");
                        nameProgram = "";
                        break;

                }
            }

            
        }
    }
}
