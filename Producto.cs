using System;
using System.Collections.Generic;
using System.Text;

namespace ArticulosCRUD
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public Producto(int id, string nombre, int cantidad, int precio)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Precio {Precio}, Cantidad: {Cantidad}";
        }
    }
}
