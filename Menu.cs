using System;
using System.Collections.Generic;
using System.Text;

namespace ArticulosCRUD
{
    public class Menu
    {
        public Menu()
        {
        }

        public void MostrarMenu()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("======================");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar ");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("0. Salir");
                string opcion = Console.ReadLine() ?? "";
                switch (opcion)
                {
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
