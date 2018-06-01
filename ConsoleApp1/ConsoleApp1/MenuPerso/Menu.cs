using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.MenuPerso
{
    class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            var menuItems = new List<MenuItem>();
        }

        /// <summary>
        /// Insère un menuItem dans le menu
        /// </summary>
        /// <param name="item">Elements à insérer dans le menu</param>
        /// <exception cref="ArgumentException">Si le numéro de l'item est déjà présent dans le menu</exception>

        public void InsererLigne(MenuItem item)
        {
            //foreach (var ligne in menuItems)
            //{
            //    if (ligne.Numero == item.Numero)
            //    {
            //        throw new ArgumentException($"Le numéro {item.Numero} existe déjà dans le menu");
            //    }
            //}

            if (menuItems.Exists(x => x.Numero == item.Numero))
            {
                throw new ArgumentException($"Le numero {item.Numero} existe déjà dans le menu");
            }

            menuItems.Add(item);
        }

        public void Afficher()
        {

            {
                //Affiche les éléments du menu
                foreach (MenuItem ligne in menuItems)
                {
                    Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");
                }
                //Recupère le choix de l'utilisateur
                Console.WriteLine("Saisir le numero de votre choix:");
                int choix;
                choix = int.Parse(Console.ReadLine());
            }

        }
        public int Choisir()
        {

            //Recupère le choix de l'utilisateur
            Console.WriteLine("Saisir le numero de votre choix:");
            int choix;
            choix = int.Parse(Console.ReadLine());

            while (true)
            {
                foreach (MenuItem item in menuItems)
                {
                    if (choix == item.Numero)
                    {
                        return choix;
                    }


                    //message retour pour une selection qui n'existe pas dans la liste
                    Console.WriteLine("Erreur de saisie");
                    return -1;

                    //return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;
                }
            }
        }
    }
}
        