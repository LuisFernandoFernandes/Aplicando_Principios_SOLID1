using Aplicando_Principios_SOLID1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1
{
    class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoFidelidade GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;
                case StatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIP();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return calcular;
        }
    }
}
