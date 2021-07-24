using System;

namespace CursoFoop_Solid_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celularSamsung = new Celular(new PromocaoDiaMaes());
            celularSamsung.Nome = "Celular Samsung";
            celularSamsung.Preco = 1000;
            var precoCelular = celularSamsung.PrecoVenda();
            Console.WriteLine($"{celularSamsung.Nome} com desconto : R${precoCelular}");

            Produto perfumeChanel = new Perfume(new PromocaoDiaNamorados());
            perfumeChanel.Nome = "Celular Samsung";
            perfumeChanel.Preco = 1000;
            var precoPerfume = perfumeChanel.PrecoVenda();
            Console.WriteLine($"{perfumeChanel.Nome} com desconto : R${precoPerfume}");
        }
    }
}
