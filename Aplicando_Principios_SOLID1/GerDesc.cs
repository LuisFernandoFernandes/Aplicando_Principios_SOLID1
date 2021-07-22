using Aplicando_Principios_SOLID1.Enums;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = preco;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_Comum * preco));
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos)
                     break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_Especial * preco));
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos)
                     break;
                case StatusContaCliente.ClienteVIP:
                    precoAposDesconto = (preco - (Constantes.Desconto_Cliente_VIP * preco));
                    precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos)
                     break;
                default:
                    throw new NotImplementedException();
            }
            return precoAposDesconto;
        }
    }
}
