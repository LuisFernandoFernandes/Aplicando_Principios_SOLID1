using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Solid_Exercicio4
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        protected IPromocao promocao;
        //injecao de dependencia
        public Produto(IPromocao _promocao)
        {
            promocao = _promocao;
        }

        public decimal DescontoPromocao()
        {
            return promocao.Desconto();
        }
        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}
