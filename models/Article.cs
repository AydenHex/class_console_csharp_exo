using System;

namespace class_console.models
{
    public enum TypeArticle {Alimentaire, Droguerie, Habillement, Loisir};
    public class Article
    {
        protected string designation;
        protected int prix;
        protected int quantite;
        protected TypeArticle typeArticle;

        public Article() {}
        public Article(string designation, int prix, TypeArticle typeArticle, int quantite) {
            this.typeArticle = typeArticle;
            this.designation = designation;
            this.prix = prix;
            this.quantite = quantite;
        }

        public string Designation {
            get { return this.designation; }
            set { this.designation = value; }
        }

        public int Prix {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public TypeArticle TypeArticle {
            get { return this.typeArticle; }
            set { this.typeArticle = value; }
        }

        public int Quantite {get; set;}

        public void Ajouter(int quantite) {
            this.quantite += quantite;
        }

        public void Retirer(int quantite) {
            if (quantite > this.quantite) {
                throw new System.ArgumentException("La quantite à retirer ne peux être supérieur a la quantité en stock: " + this.quantite);
            }
            this.quantite -= quantite;
        }

        public override string ToString() {
            return string.Format("Designation:{0}, Quantite:{1}, Prix:{2}, TypeArticle:{3}", this.designation, this.quantite, this.prix, this.typeArticle);
        }
        public void acheter() {
            Console.WriteLine(this);
        }
    }
}