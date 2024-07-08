using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Producto prod = new Producto("Manteca", 200);
            Producto prod1 = new Producto("Leche", 350);
            Producto prod2 = new Producto("Bagel", 140);

            Usuario usuario = new Usuario("Flor Giova");
            Usuario usuario2 = new Usuario("Ambar Perciante");

            string resp = "sus";

            while (resp == "sus" || resp == "desu" || resp == "precio")
            {
                Console.WriteLine("Producto: " + prod.Nombre + ", Precio: " + prod.Precio);
                Console.WriteLine("Usuario: " + usuario.Nombre);

                Console.WriteLine("Que desea hacer? Suscribir (sus), Desuscribir (desu), Cambiar Precio del Producto (precio)");
                resp = Console.ReadLine();

                switch (resp)
                {
                    case "sus":
                        prod.Subscribir(usuario);
                        break;
                    case "desu":
                        prod.Desusbcribir(usuario);
                        break;
                    case "precio":
                        Console.WriteLine("Que precio desea ponerle?");
                        var ans = Console.ReadLine();
                        prod.Precio = Convert.ToDouble(ans);
                        break;
                }

                Console.ReadKey();
            }
           
        }
    }
}
