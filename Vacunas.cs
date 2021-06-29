using System;
using System.Collections.Generic;
using System.Text;

namespace Vacuna
{
    class Vacunas
    {
        //declaracion de variables
        protected String nombreVacuna;
        protected String[] efectosSecundarios;
        protected String informacionGeneral;
        protected Boolean aceptaTerminos;
        protected double dosis;

        //constructor
        public Vacunas(String nombreVacuna, String[]efectosSecundarios, String informacionGeneral, Boolean aceptaTerminos, int dosis)
        {
            this.nombreVacuna = nombreVacuna;
            this.efectosSecundarios = efectosSecundarios;
            this.informacionGeneral = informacionGeneral;
            this.aceptaTerminos = aceptaTerminos;
            this.dosis = dosis; 

        }

        //constructor vacio
        public Vacunas()
        {

        }

        //metodo para  mostrar informacion
        public void informacion()
        {
            System.Console.WriteLine("\n Nombre de la Vacuna : " + nombreVacuna);
            System.Console.WriteLine("\n Efectos Secundarios: " + efectosSecundarios);
            System.Console.WriteLine("\n Informacion General: " + informacionGeneral);
            System.Console.WriteLine("\n Aceptacion de Terminos: " + aceptaTerminos);
            System.Console.WriteLine("\n Dosis: " + dosis);

        }

       
        //metodo inyectar
        //b.La aplicación llama al método inyectar y simula el proceso indicando al paciente con mensajes en consola lo 
        //    que sucede en su cuerpo(Se debe indicar el proceso de acuerdo al tipo de vacuna).
        //c.La aplicación indica al paciente la finalización de la aplicación.
       
        public void inyectar(int dosis)
        {
            this.dosis = dosis;
            Console.WriteLine("Esta recibiendo la vacuna " + nombreVacuna + " para el Covid 19");
            Console.WriteLine("\n Esto es lo que esta vacuna realiza en su cuerpo: ");
            Console.WriteLine("\n" + informacionGeneral);

            //b)Caso de uso “Aplicar vacuna dosis 1”
            //a.El paciente elige la opción aplicar vacuna
            //b.La aplicación llama al método inyectar y simula el proceso indicando al paciente con mensajes en consola lo que sucede en su cuerpo (Se debe indicar el proceso de acuerdo al tipo de vacuna).
            //c.La aplicación indica al paciente la finalización de la aplicación.
            //d.La aplicación indica al paciente la fecha en que debe aplicarse la segunda dosis tomando en cuenta la fecha actual.

            if (dosis == 1)
            {
                Console.WriteLine("\nLa aplicacion de su primera dosis ha terminado");
                Console.WriteLine("\nLa fecha de su segunda dosis es en: ");
                //d.La aplicación indica al paciente la fecha en que debe aplicarse la segunda dosis tomando en cuenta la fecha actual.
                DateTime fechaPrimerDosis = DateTime.Today;
                DateTime fechaSegundaDosis = fechaPrimerDosis.AddDays(21);
                Console.WriteLine("\n" + fechaSegundaDosis);
            }
            //opcion si el paciente elige  la segunda dosis
            // c)Caso de uso “Aplicar vacuna dosis 2”
            //a.El paciente elige el menú aplicar segunda dosis.
            //b.La aplicación llama al método inyectar y simula el proceso indicando al paciente con mensajes en consola lo que sucede en su cuerpo (Se debe indicar el proceso de acuerdo al tipo de vacuna).
            //c.La aplicación indica al paciente la finalización de la aplicación.
            if (dosis == 2)
            {
                Console.WriteLine("\nLa aplicacion de su segunda dosis ha terminado");

            }
            
        }
        public void inyectar(double dosis)
        {
            this.dosis = dosis;
            Console.WriteLine("Esta recibiendo la vacuna " + nombreVacuna + " para el Covid 19");
            Console.WriteLine("\n Esto es lo que esta vacuna realiza en su cuerpo: ");
            Console.WriteLine("\n" + informacionGeneral);

            //b)Caso de uso “Aplicar vacuna dosis 1”
            //a.El paciente elige la opción aplicar vacuna
            //b.La aplicación llama al método inyectar y simula el proceso indicando al paciente con mensajes en consola lo que sucede en su cuerpo (Se debe indicar el proceso de acuerdo al tipo de vacuna).
            //c.La aplicación indica al paciente la finalización de la aplicación.
            //d.La aplicación indica al paciente la fecha en que debe aplicarse la segunda dosis tomando en cuenta la fecha actual.

            if (dosis == 1)
            {
                Console.WriteLine("\nLa aplicacion de su primera dosis ha terminado");
                Console.WriteLine("\nLa fecha de su segunda dosis es en: ");
                //d.La aplicación indica al paciente la fecha en que debe aplicarse la segunda dosis tomando en cuenta la fecha actual.
                DateTime fechaPrimerDosis = DateTime.Today;
                DateTime fechaSegundaDosis = fechaPrimerDosis.AddDays(21);
                Console.WriteLine("\n" + fechaSegundaDosis);
            }
            //opcion si el paciente elige  la segunda dosis
            // c)Caso de uso “Aplicar vacuna dosis 2”
            //a.El paciente elige el menú aplicar segunda dosis.
            //b.La aplicación llama al método inyectar y simula el proceso indicando al paciente con mensajes en consola lo que sucede en su cuerpo (Se debe indicar el proceso de acuerdo al tipo de vacuna).
            //c.La aplicación indica al paciente la finalización de la aplicación.
            if (dosis == 2)
            {
                Console.WriteLine("\nLa aplicacion de su segunda dosis ha terminado");

            }

        }
        //get setters
        public String NombreVacuna
        {
            get { return this.nombreVacuna; }
            set { this.nombreVacuna = nombreVacuna; }
        }

        public String[] EfectosSecundarios
        {
            get { return this.efectosSecundarios; }
            set { this.efectosSecundarios = efectosSecundarios; }
        }

        public String InformacionGeneral
        {
            get { return this.informacionGeneral; }
            set { this.informacionGeneral = informacionGeneral; }
        }

        public Boolean AceptaTerminos
        {
            get { return this.aceptaTerminos; }
            set { this.aceptaTerminos = aceptaTerminos; }
        }

        public double Dosis
        {
            get { return this.dosis; }
            set { this.dosis = dosis; }
        }
    }
}
