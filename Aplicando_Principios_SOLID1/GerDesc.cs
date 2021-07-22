using Aplicando_Principios_SOLID1.Enums;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDescontos
    {
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? (decimal)5 / 100 : (decimal)tempoDeContaEmAnos / 100;
            if (statusContaCliente == StatusContaCliente.NaoRegistrado)
            {
                precoAposDesconto = precoProduto;
            }
            else if (statusContaCliente == StatusContaCliente.ClienteComum)
            {
                precoAposDesconto = (precoProduto - (0.1m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
            }
            else if (statusContaCliente == StatusContaCliente.ClienteEspecial)
            {
                precoAposDesconto = (0.7m * precoProduto) - descontoPorFidelidade * (0.7m * precoProduto);
            }
            else if (statusContaCliente == StatusContaCliente.ClienteVIP)
            {
                precoAposDesconto = (precoProduto - (0.5m * precoProduto)) - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
            }
            return precoAposDesconto;
        }
    }
}
