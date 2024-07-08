using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISujetoProducto
    {
        void Subscribir(IObserverUsuario usuario);

        void Desusbcribir(IObserverUsuario usuario);

        void Notificar();
    }
}
