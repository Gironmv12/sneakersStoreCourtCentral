using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.metodos
{
    public class gProductos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Talla { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int ProveedorId { get; set; }

        public gProductos(int id, string nombre, string talla, decimal precio, int cantidad, int proveedorId=0)
        {
            Id = id;
            Nombre = nombre;
            Talla = talla;
            Precio = precio;
            Cantidad = cantidad;
            ProveedorId = proveedorId;
        }

    }
}
