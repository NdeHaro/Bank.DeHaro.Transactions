using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{
    interface IUser
    {
        public void enviarDinero(Client clienteAEnviar);
        public void recibirNotificaciones();
        public void pedirPrestamo();
        public void calculatTipoInteres();


    }
}
