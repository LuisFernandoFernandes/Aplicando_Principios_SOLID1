using Aplicando_Principios_SOLID1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1
{
    public interface ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoFidelidade GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
