using System;
using class_console.models;
using class_console.utils;

namespace class_console
{
    class Program
    {
        static void Main(string[] args)
        {
            models.Article monArticle = new models.Article("Chaussures", 7, models.TypeArticle.Habillement, 22);
            models.Article monArticle2 = new models.Article("Ratcher & Clank 2", 22, models.TypeArticle.Habillement, 12);
            models.Article monArticle3 = new models.Article("PQ", 2, models.TypeArticle.Droguerie, 54);

            models.Livre monLivre = new models.Livre("Harry Potter à l'école des sorciers !", 7, "fedzf171zf78rf", 170, models.TypeArticle.Loisir, 3);
            models.Disque monDisque = new models.Disque("The Beattles, compilation", 15, "Universal", models.TypeArticle.Loisir, 5);
            models.Video maVideo = new models.Video("Harry Potter et la chambre des secrets", 12, 135, models.TypeArticle.Loisir, 7);
            models.Poche monLivreDePoche = new models.Poche("Harry Potter et le prisionnier d'Azkaban", 9, "fefnufener548fe", 120, "Fantastique", models.TypeArticle.Loisir, 78);
            models.Broche monLivreBroche = new models.Broche("Harry Potter et la coupe de feu", 17, "inezufnefre515f", 170, models.TypeArticle.Loisir, 122);

            // monArticle.acheter();
            // monArticle.Ajouter(8);
            // monArticle.acheter();

            // utils.TestsArticle testsArticle = new TestsArticle();
            // testsArticle.LaunchTestCreation();

            models.Article[] tableauArticle = new models.Article[3];
            tableauArticle[0] = monArticle;
            tableauArticle[1] = monArticle2;
            tableauArticle[2] = monArticle3;

            tableauArticle[0].Retirer(11);
            monArticle3.Ajouter(6);

            foreach(models.Article lArticle in tableauArticle) {
                Console.WriteLine(lArticle);
            }



        }
    }
}
