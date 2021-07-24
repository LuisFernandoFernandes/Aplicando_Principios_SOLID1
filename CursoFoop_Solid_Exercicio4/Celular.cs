using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Solid_Exercicio4
{
    class Celular : Produto
    {
        public Celular(IPromocao PromocaoDiaMaes) : base(PromocaoDiaMaes)
        {}
    }
}
