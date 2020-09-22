namespace class_console.models
{
    public class Livre : Article
    {
        protected string isbn;
        protected int nbPages;

        public Livre(string designation, int prix, string isbn, int nbPages, TypeArticle typeArticle, int quantite) : base(designation, prix, typeArticle, quantite) {
            this.isbn = isbn;
            this.nbPages = nbPages;
        }

        public string Isbn {
            get { return this.isbn; }
            set { this.isbn = value; }
        } 

        public int NbPages {
            get { return this.nbPages; }
            set { this.nbPages = value; }
        }
    }
}