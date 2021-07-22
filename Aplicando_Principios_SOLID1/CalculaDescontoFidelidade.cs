using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID1
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.Desconto_Maximo_Por_Fidelidade) ?
                 (decimal)Constantes.Desconto_Maximo_Por_Fidelidade / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}
