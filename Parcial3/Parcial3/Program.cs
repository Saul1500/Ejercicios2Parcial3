using Parcial3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

class Program
{
    static void Main()
    {
        using (var contextdb = new ContextDB())
        {
            bool Continuar = true;
            while (Continuar)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("");
                Console.WriteLine("BIENVENIDOS AL MENU DEL CRUD DE LA BASE DE DATOS");
                Console.WriteLine("");
                Console.WriteLine("***********************************************");
                Console.WriteLine("");
                Console.WriteLine("1 Insertar Datos");
                Console.WriteLine("");

                int op1 = Convert.ToInt32(Console.ReadLine());

                switch (op1)
                {
                    case 1:
                        contextdb.Database.EnsureCreated();

                        notas estudiante = new notas();

                        Console.WriteLine("Ingrese el nombre del Estudiante: ");
                        estudiante.Estudiante = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del laboratorio 1: ");
                        estudiante.laboratorio1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del laboratorio 2: ");
                        estudiante.laboratorio2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del laboratorio 3: ");
                        estudiante.laboratorio3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del Parcial 1: ");
                        estudiante.Parcial1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del Parcial 2: ");
                        estudiante.Parcial2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingrese la Primer nota del Parcial 3: ");
                        estudiante.Parcial3 = Convert.ToInt32(Console.ReadLine());

                        contextdb.Add(estudiante);
                        contextdb.SaveChanges();

                        Console.WriteLine("Datos Agregados Correctamente.");
                        Console.WriteLine("");
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Desea continuar (EN MAYUSCULAS S/N)? Precione S/N");
                var cont = Console.ReadLine();
                if (cont.Equals("N"))
                {
                    Continuar = false;
                }

            }
            Console.WriteLine("");

            Console.WriteLine("LISTADO DE LOS DATOS:");
            Console.WriteLine("");

            foreach (var s in contextdb.notas)
            {
                Console.WriteLine($"Laboratorio1: {s.laboratorio1}, Laboratorio2: {s.laboratorio2}, Laboratorio3: {s.laboratorio3}, Parcial 1: {s.Parcial1}, parcial 2: {s.Parcial2}, parcial 3: {s.Parcial3}");
            }
        }
    }
}