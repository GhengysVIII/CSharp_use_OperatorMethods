﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace use_OperatorMethods {
    internal class CollectionCartes {
        public Dictionary<Carte, int> Cartes { get; set; } = new Dictionary<Carte, int>(); 

    public CollectionCartes() {
        }
        public CollectionCartes(Dictionary<Carte, int> Cartes) {
            this.Cartes = Cartes;
        }
        public static CollectionCartes operator +(CollectionCartes d1, Carte c) {
            var c2 = d1.Cartes.Where((k) => k.Key.Name == c.Name).FirstOrDefault();
            if (c2.Key == null) {
                d1.Cartes.Add(c, 1);
            } else {
                d1.Cartes[c] += 1; 
            }
            return d1;
        }
        public static CollectionCartes operator -(CollectionCartes d1, Carte c) {
            var c2 = d1.Cartes.Where((k) => k.Key.Name == c.Name).FirstOrDefault();
            if (c2.Key != null && c2.Value > 0 ) {
                d1.Cartes[c] -= 1;
            }
            return d1;
        }


        /*public static implicit operator CollectionCartes(Dictionary<Carte, int> v) {
            v.Add();
        }*/
    }
}