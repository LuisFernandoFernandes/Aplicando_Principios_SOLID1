using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
        decimal AplicarDescontoStatusConta(decimal preco);
    }
}
