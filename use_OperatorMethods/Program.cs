using System;

namespace use_OperatorMethods {
    class Program {
        static void Main(string[] args) {

            CollectionCartes col = new CollectionCartes();
            Carte c1 = new Carte("Rockanos");
            Carte c2 = new Carte("Djiinaos");

            // ajouter des cartes
            col += c1;
            col += c1; 
            col += c2;
            foreach (var c in col.Cartes) {
                Console.WriteLine("key {0}, value {1}",c.Key.Name,c.Value);
            }

            // retirer des cartes ( pour tester le minimum 0 )
            col -= c1;
            col -= c1;
            col -= c1;
            foreach (var c in col.Cartes) {
                Console.WriteLine("key {0}, value {1}", c.Key.Name, c.Value);
            }

        }
    }
}
