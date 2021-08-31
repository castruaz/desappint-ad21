using System;
using static System.Console;

namespace p06_pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub, lug;
            string[] ings;

            string tamaño, cubierta, lugar;
            string ingredientes="";

            if(args.Length<3) {
                Menu();
                return 1;
            }
            // Tamano
            tam = char.Parse(args[0].ToUpper());
            if(tam=='P') tamaño="Pequeña";
            else if(tam=='M') tamaño="Mediana";
            else tamaño="Grande";

            // Ingrediente
            ings = args[1].Split("+");
            foreach(string i in ings) {
                switch(  char.Parse(i.ToUpper()) )
                {
                    case 'C' : ingredientes += "Champinones "; break;
                    case 'E' : ingredientes += "Extraqueso "; break;
                    case 'P' : ingredientes += "Pina "; break;
                    case 'T' : ingredientes += "Tomates "; break;
                }
            }
            // Cubierta
            cub = char.Parse(args[2].ToUpper());
            if(cub=='D') cubierta = "Delgada"; else cubierta="Gruesa"; 
            // Lugar
            lug = char.Parse(args[3].ToUpper());
            lugar = (lug=='A' ? "Aqui" : "Llevar");


            WriteLine("Tu piazza es de tamano: {0}", tamaño);
            WriteLine("Ingredientes: {0}", ingredientes);
            WriteLine("Cubierta: {0}", cubierta);
            WriteLine("Lugar: {0}", lugar);

            return 0;
        }
        static void Menu() {
            Clear();
            WriteLine("Tamano: (P)equena , (M)ediana, (G)rande");
            WriteLine("Ingredientes: C hampinones + E xtra queso + P ina + T omates");
            WriteLine("Cubierta: (D)elgada , (G)ruesa ");
            WriteLine("Donde: (A)qui , (L)levar ");

        }
    }
}
