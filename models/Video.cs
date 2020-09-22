using System;

namespace class_console.models
{
    public class Video : Article
    {
        protected int duree;

        public Video(string designation, int prix, int duree, TypeArticle typeArticle, int quantite) : base(designation, prix, typeArticle, quantite) {
            this.duree = duree;
        }

        public int Duree {
            get { return this.duree; }
            set { this.duree = value; }
        }

        public void afficher() {
            Console.WriteLine("Video affichée : " + this.designation);
        }
    }
}