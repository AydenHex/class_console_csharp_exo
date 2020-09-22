namespace class_console.models
{
    public class Poche : Livre
    {
        private string categorie;
        public Poche(string designation, int prix, string isbn, int nbPages, string categorie) : base(designation, prix, isbn, nbPages) {
            this.categorie = categorie;
        }

        public string Categorie {get; set;}
    }
}