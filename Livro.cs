using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPoo
{
    public class Livro
    {
        public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public Livro()
    {
        Titulo = "Sem Título";
        Autor = "Desconhecido";
        NumeroPaginas = 0;
    }

    public Livro(string titulo) : this()
    {
        Titulo = titulo;
    }

    public Livro(string titulo, string autor) : this(titulo)
    {
        Autor = autor;
    }

    public Livro(string titulo, string autor, int numeroPaginas) : this(titulo, autor)
    {
        NumeroPaginas = numeroPaginas;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Páginas: {NumeroPaginas}");
    }
    }
}