using pizza.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace pizza.Model
{
    public class Pizza
    {
        public string nom { get; set; }
        public string imageUrl { get; set; }
        public int prix { get; set; }
        public string []ingredients { get; set; }
        public string PrixEuros {  get { return prix + "€"; } }
        public string IngredientStr { get { return String.Join(", ", ingredients); } }
        public string Titre { get { return StrigExtensions.PremiereLettreMajuscule(nom); } }
        public Pizza()
        {

        }

    }
    
}
