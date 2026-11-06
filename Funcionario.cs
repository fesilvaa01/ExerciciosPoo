using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPoo
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    
    // Leitura pública e escrita privada
    public decimal Salario { get; private set; }

    public Funcionario(string nome, string cargo, decimal salarioInicial)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salarioInicial;
    }

    public void AumentarSalario(decimal percentual)
    {
        if (percentual > 0)
        {
            Salario += Salario * (percentual / 100);
            Console.WriteLine($"Aumento de {percentual}% aplicado com sucesso!");
        }
    }

    public void ConsultarSalario()
    {
        Console.WriteLine($"Salário atual de {Nome}: R$ {Salario:F2}");
    }
    }
}