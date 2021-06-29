using System;

namespace Vacuna
{
    class Program
    {
        static void Main(string[] args)
        {
            //a)Caso de uso “elegir vacuna”
            Console.WriteLine("Menu");
            Console.WriteLine("\n Eliga la opcion que desee");
            Console.WriteLine("\n 1. Aplicar Vacuna");
            Console.WriteLine("\n 2.Efectos Secundarios");

            String menuKey = Console.ReadLine();
            ElegirVacuna vacuna = new ElegirVacuna();

            if (menuKey == "1")
            {
                //b.La aplicación elige de forma aleatoria la aplicación de una vacuna (Pfizer, AztraZeneca ó Sputnik V)
                vacuna.elegirVacuna();
                Console.WriteLine("Favor de indicar si es esta su primera o segunda dosis");
                //b)Caso de uso “Aplicar vacuna dosis 1”
                Console.WriteLine("\n 1. Primera Dosis");
                //c)Caso de uso “Aplicar vacuna dosis 2”
                Console.WriteLine("\n 2. Segunda Dosis");
                int mDosis = Convert.ToInt32(Console.ReadLine());
                vacuna.inyectar(mDosis);
                //d)Caso de uso “Efectos secundarios”
                Console.WriteLine("\n Desea ver Efectos Secundarios");
                Console.WriteLine("\n 3. Si");
                Console.WriteLine("\n 4. No");
                menuKey = Console.ReadLine();

            }

            if(menuKey == "2")
            {
                Console.WriteLine("Aun no se ha seleccionado la vacuna que le corresponde, eliga la opcion de aplicar vacuna para ver efectos");

            }
            
            if(menuKey == "3")
            {
                vacuna.mostrarEfectosSecundarios(vacuna.NombreVacuna);
            }

        }
    }
}
