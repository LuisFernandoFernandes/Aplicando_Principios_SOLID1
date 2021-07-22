using Aplicando_Principios_SOLID1.Enums;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDescontos
    {
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = preco;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_Comum * preco));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_Especial * preco));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_VIP * preco));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }
    }
}
