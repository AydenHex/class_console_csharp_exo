using System;

namespace class_console.models
{
    public class Disque : Article
    {
        protected string label;

        public Disque(string designation, int prix, string label, TypeArticle typeArticle, int quantite) : base(designation, prix, typeArticle, quantite) {
            this.label = label;
        }

        public string Label {
            get { return this.label; }
            set { this.label = value; }
        }

        public void ecouter() {
            Console.WriteLine("Disque écouté : " + this.designation);
        }
    }
}