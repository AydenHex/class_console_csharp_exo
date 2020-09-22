namespace class_console.models
{
    public class Broche : Livre
    {
        public Broche(string designation, int prix, string isbn, int nbPages, TypeArticle typeArticle, int quantite) : base(designation, prix, isbn, nbPages, typeArticle, quantite) {

        }
    }
}