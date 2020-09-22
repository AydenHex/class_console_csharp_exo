using System;
using class_console.models;

namespace class_console.utils
{
    public class TestsArticle
    {
        public TestsArticle() {
        
        }

        public void LaunchTestCreation() {
            Article article = new Article();

            Console.WriteLine("Creation d'un nouvel objet Article.\n S'il vous plait remplissez les informations ci-dessous:");
            article = new models.Article();

            Console.WriteLine("(designation):");
            article.Designation = Console.ReadLine();

            Console.WriteLine("(prix):");
            try {
                article.Prix = Int32.Parse(Console.ReadLine());
            }
            catch (InvalidCastException) {
                throw new InvalidCastException("Please use a integer");
            }
            Console.WriteLine("(Type [Alimentaire, Droguerie, Habillement, Loisir]):");
            string type = Console.ReadLine();
            try {
                var typeArt = (models.TypeArticle) Enum.Parse(typeof(models.TypeArticle), type);
                article.TypeArticle = typeArt;
            } catch (Exception) {
                throw new InvalidCastException("Please use a value displayed");
            }
            Console.WriteLine("(quantite):");
            try {
                article.Quantite = Int32.Parse(Console.ReadLine());
            } catch (InvalidCastException) {
                throw new InvalidCastException("Please use a integer");
            }

            Console.WriteLine(article);
        }
    }
}