using pizza.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pizza
{
    public partial class MainPage : ContentPage
    {
        enum e_tri
        {
            TRI_AUCUN,
            TRI_NOM,
            TRI_PRIX
        }
        e_tri tri = e_tri.TRI_AUCUN;

        List<Pizza> pizzas;
        public MainPage()
        {
            InitializeComponent();
    
            pizzas = new List<Pizza>();
   
            pizzas.Add(new Pizza { nom = "végetarienne", prix = 7, ingredients = new string[] { "tomate", "poivrons", "oignons" }, imageUrl= "https://img.cuisineaz.com/660x660/2013/12/20/i18445-margherite.jpeg" });
            pizzas.Add(new Pizza { nom = "montagnarde", prix = 11, ingredients = new string[] { "reblochon", "pomme de terre", "oignons", "crème" }, imageUrl = "https://www.galbani.fr/wp-content/uploads/2017/07/pizza_maison.jpg" });
            pizzas.Add(new Pizza { nom = "Carnivore", prix = 14, ingredients = new string[] { "tomate", "viande hachée", "mozzarella" }, imageUrl = "https://media.gqmagazine.fr/photos/5d8b7254c7191e00083ebdbb/4:3/w_1440,h_1080,c_limit/como%20hacer%20la%20mejor%20pizza%20del%20mundo.jpg" });
            pizzas.Add(new Pizza { nom = "tartiflette", prix = 17, ingredients = new string[] { "pomme de terre", "oignons", "crème fraiche", "lardons", "mozzarella" }, imageUrl = "https://tastiesfoods.com/wp-content/uploads/2020/11/La-recette-de-pizza-quatre-fromages.jpg" });
            pizzas.Add(new Pizza { nom = "mexicaine", prix = 10, ingredients = new string[] { "boeuf", "mozzarella", "maïs", "tomates", "oignon", "coriandre" }, imageUrl = "https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2FFAC.2Fvar.2Ffemmeactuelle.2Fstorage.2Fimages.2Fminceur.2Fastuces-minceur.2Fminceur-choix-pizzeria-47943.2F14883894-1-fre-FR.2Fminceur-comment-faire-les-bons-choix-a-la-pizzeria.2Ejpg/750x562/quality/80/crop-from/center/minceur-comment-faire-les-bons-choix-a-la-pizzeria.jpeg" });
            pizzas.Add(new Pizza { nom = "reine", prix = 8, ingredients = new string[] { "jambon", "champignons", "sauce tomate", "mozzarella" }, imageUrl = "https://static.cuisineaz.com/400x320/i96018-pizza-reine.jpg" });
            pizzas.Add(new Pizza { nom = "chèvre et miel", prix = 9, ingredients = new string[] { "jambon", "chevre", "miel" }, imageUrl = "https://static.restovisio.com/uploads/2014/03/Eq_it-na_pizza-margherita_sep2005_sml1.jpg" });
            pizzas.Add(new Pizza { nom = "peur", prix = 18, ingredients = new string[] { "fantome", "arraignée", "sorcière" }, imageUrl = "https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Ffac.2F2019.2F09.2F09.2Fee1aaf5a-0c1d-40cc-8305-18a18e6c2add.2Ejpeg/750x562/quality/80/crop-from/center/cr/wqkgSSBTdG9jayAvIEZlbW1lIEFjdHVlbGxl/focus-point/1307%2C686/pizza-fantome-pour-halloween.jpeg" });
            listView.ItemsSource= pizzas;
        }

        private void sortButton_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("sortButton_Clicked");
            if(tri == e_tri.TRI_AUCUN)
            {
                tri = e_tri.TRI_NOM;
            }
            else if (tri == e_tri.TRI_NOM)
            {
                tri = e_tri.TRI_PRIX;
            }
            else if (tri == e_tri.TRI_PRIX)
            {
                tri = e_tri.TRI_AUCUN;
            }
            sortButton.Source = GetImageSourceFromTri(tri);
        }
        private string GetImageSourceFromTri(e_tri t)
        {
            switch (t){
                case e_tri.TRI_NOM: return "sort_nom.png";
                case e_tri.TRI_PRIX: return "sort_prix.png";
            }
            return "sort_none.png";
        }
        private List<Pizza> GetPizzasFromTri(e_tri t, List<Pizza> l)
        {
            if(l == null)
            {
                return null;
            }
            switch (t)
            {
                case e_tri.TRI_NOM: 
                    {
                        List<Pizza> ret = new List<Pizza>(l);
                        ret.Sort((p1, p2) => { return p1.Titre.CompareTo(p2.Titre); });
                        return ret;
                    }
                case e_tri.TRI_PRIX:
                    {
                        List<Pizza> ret = new List<Pizza>(l);
                        ret.Sort((p1, p2) => { return p2.prix.CompareTo(p1.prix); });
                        return ret;
                    }
                    
            }
            return l;
        }
    }
}
    