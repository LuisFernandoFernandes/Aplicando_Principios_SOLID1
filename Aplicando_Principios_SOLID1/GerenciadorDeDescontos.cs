using Aplicando_Principios_SOLID1.Enums;
using System;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDescontos(ICalculaDescontoStatusContaFactory _descontoStatusConta, ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoStatusConta = _descontoStatusConta;
            descontoFidelidade = _descontoFidelidade;
        }
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculoDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(preco);

            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
            return precoAposDesconto;
        }
    }
}
