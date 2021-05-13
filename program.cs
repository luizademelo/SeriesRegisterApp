using System;

namespace SeriesRegisterApp{
    
    class program{
        
        static void Main(string[] args){

            string userOption = getUserOption();
            
            while (userOption != "X"){
                switch(userOption){
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        InsertSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "5":
                        VisualizeSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = getUserOption();
            }

            Console.WriteLine("Thank you for using or services!!!");
            Console.WriteLine();
            
        }


        //Implementations

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


        private static void DeleteSerie(){

            Console.WriteLine("Type the serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());

            repository.Delete(serieIndex);
        }


        private static void VisualizeSerie(){
            
            Console.WriteLine("Type the serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());
            var serie = repository.GetById(serieIndex);
            Console.WriteLine(serie);
        }


        private static void UpdateSerie(){
            Console.WriteLine("Type the serie's id: ");
            int serieIndex = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Gender))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

            Console.WriteLine("Type the gender among the options above: ");
            int  entryGender = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the serie's title: ");
            string  entryTitle = Console.ReadLine();

            Console.WriteLine("Type the serie's year: ");
            int  entryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the serie's description: ");
            string  entryDescription = Console.ReadLine();

            Series updatedSerie = new Series(id: serieIndex,
                    Gender:(Gender)entryGender, 
                    Title: entryTitle,
                    Year: entryYear,
                    Description: entryDescription
                     );

            repository.Update(serieIndex, updatedSerie);
            }

        private static void ListSeries(){

            Console.WriteLine("List series");
            var list = repository.List();
            
            if (list.count == 0){
                Console.WriteLine("No serie is registered.");
                return;
            }

            foreach(var serie in list){
                var excluded = Series.getExcluded();
                Console.WriteLine("#ID {0}: {1} {2}", serie.getID(), serie.getTitle(), (excluded? "Excluded": ""));
            }
        }

        private static void InsertSerie(){
            Console.WriteLine("Insert new serie");

            foreach(int i in Enum.GetValues(typeof(Gender))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
            }

             Console.WriteLine("Type the gender among the options above: ");
            int  entryGender = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the serie's title: ");
            string  entryTitle = Console.ReadLine();

            Console.WriteLine("Type the serie's year: ");
            int  entryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the serie's description: ");
            string  entryDescription = Console.ReadLine();

            Series newSerie = new Series(id:repository.NextId(),
                    Gender:(Gender)entryGender, 
                    Title: entryTitle,
                    Year: entryYear,
                    Description: entryDescription );

            repository.Insert(newSerie);
        }






    }
}