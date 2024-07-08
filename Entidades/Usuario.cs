using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : IObserverUsuario
    {
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre; 
        }
        public void Actualizar(Producto producto)
        {
            Console.WriteLine("El usuario "+ this.Nombre + " recibio la notificacion del producto "+ producto.Nombre + " al nuevo precio de "+ producto.Precio);
        }
    }
}
