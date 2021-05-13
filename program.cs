using System;

namespace SeriesRegisterApp{
    
    class program{
        
        static void Main(string[] args){

            string userOption = getUserOption;
            
            while (userOption != "X"){
                switch(userOption){
                    case "1":
                        ListSeries();
                    case "2":
                        InsertSerie();
                    case "3":
                        UpdateSerie();
                    case "4":
                        DeleteSerie();
                    case "5":
                        VisualizeSerie();
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            
        }

        private static string getUserOption(){
            Console.WriteLine();
            Console.WriteLine("Welcome to ScarSeries!!!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 = List TV series");
            Console.WriteLine("2 = Insert new TV serie");
            Console.WriteLine("3 = Update TV serie");
            Console.WriteLine("4 = Delete TV serie");
            Console.WriteLine("5 = Visualize TV serie");
            Console.WriteLine("C = Clear screen");
            Console.WriteLine("X = Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper;
            return userOption;
        }
    }
}