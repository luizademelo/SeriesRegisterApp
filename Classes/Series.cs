namespace SeriesRegisterApp
{
    public class Series : BaseEntity{
        //Atributes
        private Genre Genre {get; set;}
        private string  Title {get; set;}
        private string Description {get; set;}
        private int Year {get; set;}
        private bool Excluded {get; set;}

        public Series(int id, Genre genre, string title, string description, int year){
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excluded = false;
        }

        public override ToString(){
            string retorno = "";
            retorno += "Genre: " + this.Genre + Enviroment.NewLine;
            retorno += "Title: " + this.Title + Enviroment.NewLine;
            retorno += "Description: " + this.Description + Enviroment.NewLine;
            retorno += "Year: " + this.Year + Enviroment.NewLine;
            return retorno;           
        }

        public string getTitle(){
            return this.Title;
        }

        public string getID(){
            return this.Id;
        }

        public void exclude(){
            this.Excluded = true;
        }
            
    }
}