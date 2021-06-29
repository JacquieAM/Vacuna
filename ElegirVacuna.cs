using System;
using System.Collections.Generic;
using System.Text;

namespace Vacuna
{
    class ElegirVacuna : Vacunas
    {
        public String[] listaVacunas;
       
        public ElegirVacuna(String nombreVacuna, String[] efectosSecundarios, String informacionGeneral, Boolean aceptaTerminos, int dosis,
            String[] listaVacunas)
            : base(nombreVacuna, efectosSecundarios, informacionGeneral, aceptaTerminos, dosis)
        {
            this.listaVacunas = listaVacunas;
            
        }

        //constructor vacio
        public ElegirVacuna()
        {

        }
        // metodo Pfizer

        public void pfizer()
        {
            String[] efectosSecundarios = { "hinchazon", "dolor", "cefalea", "escalofrio", "fiebre", "fatiga", "mialgia", "artralgia" };

            this.nombreVacuna = "Pfizer";
            this.informacionGeneral = "El ARN  entra en las celulas causando que fabriquen proteinas de la espicula del coronavirus";

        }

        // metodo Astra Zeneca
        public void astraZeneca()
        {
            String[] efectosSecundarios = { "sensibilidad", "dolor", "calor", "prurito", "moreton", "cefalea", "escalofrios" };
            this.nombreVacuna = "Astra Zeneca";
            this.informacionGeneral = "El ADN se copia en un ARN en el nucleo, este migra al citoplasma, " +
                "donde se fabrican las roteinas virales";
        }

        //metodo Sputnik V

        public void sputnikV()
        {
            String[] efectosSecundarios = { "enrojecimiento", "dolor", "fatiga", "gripa" };
            this.nombreVacuna = "Sputnik V";
            this.informacionGeneral = "El ADN se copia en un ARN en los nucleos, este migra al citoplasma," +
                "donde se fabrican las roteinas virales";
        }

        //metodo elegir vacuna de forma aleatoria
        public void elegirVacuna()
        {
            String[] listaVacunas = { "Pfizer", "Astra Zeneca", "Sputnik V" };
            this.listaVacunas = listaVacunas;
            Random seleccionarVacuna = new Random();
            for (int i = 0; i < 3; i++)
            {
                nombreVacuna = listaVacunas[seleccionarVacuna.Next(0, listaVacunas.Length)];
            }

            Console.WriteLine("\nLa vacuna que le corresponde es: " + this.nombreVacuna);

            if (nombreVacuna == "Pfizer")
            {
                pfizer();
            }
            if (nombreVacuna == "Astra Zeneca")
            {
                astraZeneca();
            }
            if (nombreVacuna == "Sputnik V")
            {
                sputnikV();
            }
            Console.WriteLine("\nAcepta los terminos de la vacuna?");
            Console.WriteLine(" 1. Si");
            Console.WriteLine(" 2. No");
            String inputKey = Console.ReadLine();

            if (inputKey == "1")
            {
                aceptaTerminos = true;
                Console.WriteLine("\nUsted ha aceptado los terminos");
            }
            if (inputKey == "2")
            {
                aceptaTerminos = false;
                Console.WriteLine("\nUsted no ha aceptado los terminos");
                Console.WriteLine("\nSalir de la aplicacion");
                System.Environment.Exit(1);
            }

        }

        //metodo mostrar 3 efectos secundarios de forma aleatoria
        public void mostrarEfectosSecundarios(String nombreVacuna)
        {
            this.nombreVacuna = nombreVacuna;
            Console.WriteLine("\nLos efectos secundarios de la vacuna: ");
            Console.WriteLine(nombreVacuna + " son");
            Random seleccionarEfectos = new Random();

            if (nombreVacuna == "Pfizer")
            {
                pfizer();

                String[] listaEfectosSecundarios = { "hinchazon", "dolor", "cefalea", "escalofrio", "fiebre", "fatiga", "mialgia", "artralgia" };

                String efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                if (efecto1 != efecto2 && efecto2 != efecto3 && efecto1 != efecto3)
                {
                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }

                else if(efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                {
                    while (efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                    {

                        efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                    }
                    
                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }

            }
            if (nombreVacuna == "Astra Zeneca")
            {
                astraZeneca();
                String[] listaEfectosSecundarios = { "sensibilidad", "dolor", "calor", "prurito", "moreton", "cefalea", "escalofrios" };

                String efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];

                if (efecto1 != efecto2 && efecto2 != efecto3 && efecto1 != efecto3)
                {
               
                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }
                else if (efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                {
                    while (efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                    {

                        efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                    }

                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }
                
            }

            if (nombreVacuna == "Sputnik V")
            {
                sputnikV();
                String[] listaEfectosSecundarios = { "enrojecimiento", "dolor", "fatiga", "gripa" };

                String efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                String efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];

                if (efecto1 != efecto2 && efecto2 != efecto3 && efecto1 != efecto3)
                {
                 
                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }
                else if (efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                {
                    while (efecto1 == efecto2 || efecto1 == efecto3 || efecto2 == efecto3)
                    {

                        efecto1 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto2 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                        efecto3 = listaEfectosSecundarios[seleccionarEfectos.Next(0, listaEfectosSecundarios.Length)];
                    }
                   
                    Console.WriteLine(efecto1);
                    Console.WriteLine(efecto2);
                    Console.WriteLine(efecto3);
                }
            
            }


            }
    }

}