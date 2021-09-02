using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    public class Client : IUser
    {
        public string _Name;
        public Account _Account;
        public string _Pass;

        public Client(String Name, String Pass)
        {
            _Account = new Account();
            _Name = Name;
            _Pass = Pass;
        }
        void IUser.calculatTipoInteres()
        {
            throw new NotImplementedException();
        }

        void IUser.enviarDinero(this, Client receiver)
        {
            cuenta.enviarDinero(this, clienteAEnviar);
        }

        void recibirDinero(Cliente clienteRecibir)
        {
            cuenta.enviarDinero(clienteRecibir, this);
        }

        void IUser.pedirPrestamo()
        {
            throw new NotImplementedException();
        }

        void IUser.recibirNotificaciones()
        {
            throw new NotImplementedException();
        }
    }
}
