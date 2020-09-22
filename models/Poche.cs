namespace class_console.models
{
    public class Poche : Livre
    {
        private string categorie;
        public Poche(string designation, int prix, string isbn, int nbPages, string categorie, TypeArticle typeArticle, int quantite) : base(designation, prix, isbn, nbPages, typeArticle, quantite) {
            this.categorie = categorie;
        }

        public string Categorie {get; set;}
    }
}