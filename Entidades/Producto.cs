using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> usuarios;

        public string Nombre {  get; set; }

        double precio_;
        public double Precio
        {
            get
            {
                return precio_;
            }
            set
            {
                precio_ = value;
                this.Notificar();
            }
        }
        public Producto(string nombre, double precio)
        {
            usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            precio_ = precio;
        }


        public void Desusbcribir(IObserverUsuario usuario)
        {
            if (usuarios.Contains(usuario))
            {
                usuarios.Remove(usuario);
            }
            else
            {
                Console.WriteLine("El usuario " + ((Usuario)usuario).Nombre + " no se encuentra suscrito");
            }
        }

        public void Notificar()
        {
            foreach(var usuario in usuarios)
            {
                usuario.Actualizar(this);
            }

            if(usuarios.Count == 0)
            {
                Console.WriteLine("No hay suscripciones");
            }

            Console.WriteLine("--------------------------------------------------------------");
        }

        public void Subscribir(IObserverUsuario usuario)
        {
            if (!usuarios.Contains(usuario))
            {
                usuarios.Add(usuario);
                Console.WriteLine("El usuario " + ((Usuario)usuario).Nombre + "se ha suscrito");
            }
            else
            {
                Console.WriteLine("El usuario "+ ((Usuario)usuario).Nombre + " ya se encuentra suscrito");
            }
        }
    }
}
