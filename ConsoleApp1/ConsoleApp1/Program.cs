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


        }

        private static int GererMenu(List<MenuItem> menu)
        {
            foreach (MenuItem ligne in menu)
            {
                Console.WriteLine($"{ligne.Numero}-{ligne.Libelle}");
            }

            Console.WriteLine("Saisir le numero de votre choix:");
            int choix;
            choix = int.Parse(Console.ReadLine());

            foreach (MenuItem item in menu)
            {
                if (choix == item.Numero)
                {
                    return choix;
                }
            }
            Console.WriteLine("Erreur de saisie");
            return -1;

            //return menu.SingleOrDefault(x => x.Numero == choix) != null ? choix : -1;
        }
                
    }
    class MenuItem
    {
        public int Numero { get; set; }
        public string Libelle { get; set; }
    }
}









