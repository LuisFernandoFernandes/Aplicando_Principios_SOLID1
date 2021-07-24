using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_Solid_Exercicio4
{
    class Perfume : Produto
    {
        public Perfume(IPromocao PromocaoDiaNamorados) : base(PromocaoDiaNamorados) 
        { }
    }
}
