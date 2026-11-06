using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPoo
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public string Cidade { get; set; } = string.Empty;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, o meu nome é {Nome}, tenho {Idade} anos e moro em {Cidade}.");
    }
    }
}