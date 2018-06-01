using ConsoleApp1.MenuPerso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Créer des valeurs dans la liste pour afficher des valeurs
            //List<MenuItem> list = new List<MenuItem>()
            //{
            //    new MenuItem{Numero = 1, Libelle = "menu 1"},
            //    new MenuItem{Numero = 3, Libelle = "menu 3"},
            //    new MenuItem{Numero = 4, Libelle = "menu 4"},
            //    new MenuItem{Numero = 12, Libelle = "menu 12"},
            //};

            Menu menu = new Menu();
            menu.InsererLigne(new MenuItem { Numero = 1, Libelle = "Voyages" });
            menu.InsererLigne(new MenuItem { Numero = 3, Libelle = "Clients" });
            menu.InsererLigne(new MenuItem { Numero = 4, Libelle = "Dossiers" });

            menu.Afficher();
            int resultat = menu.Choisir();


            switch (resultat)
            {
                case 1:
                    SousMenuVoyage();
                    break;
                case 2:
                    SousMenuClients();
                    break;
                case 4:
                    SousMenuDossier();
                    break;
            }
            Console.ReadLine();
        }

        private static void SousMenuDossier()
        {
            Menu sousMenuDossier = new Menu();
            sousMenuDossier.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenuDossier.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenuDossier.InsererLigne(new MenuItem { Numero = 2, Libelle = "Supprimer" });

            sousMenuDossier.Afficher();
            int resultatSousMenuDossier = sousMenuDossier.Choisir();
            switch (resultatSousMenuDossier)
            {
                case 1:
                    Console.WriteLine("Vous souhaitew : Dossier => Créer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitew : Dossier => Rechercher");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitew : Dossier => Supprimer");
                    break;
            }
        }

        private static void SousMenuClients()
        {
            Menu sousMenuClients = new Menu();
            sousMenuClients.InsererLigne(new MenuItem { Numero = 1, Libelle = "Créer" });
            sousMenuClients.InsererLigne(new MenuItem { Numero = 2, Libelle = "Rechercher" });
            sousMenuClients.InsererLigne(new MenuItem { Numero = 2, Libelle = "Supprimer" });

            sousMenuClients.Afficher();
            int resultatSousMenuClients = sousMenuClients.Choisir();
            switch (resultatSousMenuClients)
            {
                case 1:
                    Console.WriteLine("Vous souhaitew : Dossier => Créer");
                    break;
                case 2:
                    Console.WriteLine("Vous souhaitew : Dossier => Rechercher");
                    break;
                case 3:
                    Console.WriteLine("Vous souhaitew : Dossier => Supprimer");
                    break;
            }
        }

                private static void SousMenuVoyage()
                {
                    Menu sousMenuVoyage = new Menu();
                    sousMenuVoyage.InsererLigne(new MenuItem { Numero = 1, Libelle = "Destination" });
                    sousMenuVoyage.InsererLigne(new MenuItem { Numero = 2, Libelle = "Compagnie" });

                    sousMenuVoyage.Afficher();
                    int resultatSousMenuVoyage = sousMenuVoyage.Choisir();
                    switch (resultatSousMenuVoyage)
                    {
                        case 1:
                            Console.WriteLine("Vous souhaitew : Voyages => Destination");
                            break;
                        case 2:
                            Console.WriteLine("Vous souhaitew : Voyages => Compagnie");
                            break;
                    }
                }
            
        
    }
}














