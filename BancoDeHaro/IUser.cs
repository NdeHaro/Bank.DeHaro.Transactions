using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    interface IUser
    {
        public void enviarDinero(Client clienteAEnviar);
        public void recibirNotificaciones();
        public void pedirPrestamo();
        public void calculatTipoInteres();


    }
}
