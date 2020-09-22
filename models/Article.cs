using System;

namespace class_console.models
{
    public class Article
    {
        protected string designation;
        protected int prix;

        public Article(string designation, int prix) {
            this.designation = designation;
            this.prix = prix;
        }

        public string Designation {
            get { return this.designation; }
            set { this.designation = value; }
        }

        public int Prix {
            get { return this.prix; }
            set { this.prix = value; }
        }

        public void acheter() {
            Console.WriteLine("Article acheté " + designation);
        }
    }
}