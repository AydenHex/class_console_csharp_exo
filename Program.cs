using System;
using class_console.models;

namespace class_console
{
    class Program
    {
        static void Main(string[] args)
        {
            models.Article monArticle = new models.Article("Article commun", 7);
            models.Livre monLivre = new models.Livre("Harry Potter à l'école des sorciers !", 7, "fedzf171zf78rf", 170);
            models.Disque monDisque = new models.Disque("The Beattles, compilation", 15, "Universal");
            models.Video maVideo = new models.Video("Harry Potter et la chambre des secrets", 12, 135);
            models.Poche monLivreDePoche = new models.Poche("Harry Potter et le prisionnier d'Azkaban", 9, "fefnufener548fe", 120, "Fantastique");
            models.Broche monLivreBroche = new models.Broche("Harry Potter et la coupe de feu", 17, "inezufnefre515f", 170);

            monArticle.acheter();
            monLivre.acheter();
            monDisque.acheter();
            maVideo.acheter();
            monLivreBroche.acheter();
            monLivreDePoche.acheter();

            monDisque.ecouter();
            maVideo.afficher();
        }
    }
}
