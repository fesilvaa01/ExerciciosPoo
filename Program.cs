using ExerciciosPOO;

Console.WriteLine("=== EXERCÍCIO 1: APRESENTAÇÃO DE PESSOAS ===");
Pessoa p1 = new Pessoa { Nome = "Ana Silva", Idade = 28, Cidade = "São Paulo" };
Pessoa p2 = new Pessoa { Nome = "Carlos Oliveira", Idade = 35, Cidade = "Curitiba" };

p1.Apresentar();
p2.Apresentar();

Console.WriteLine("\n=== EXERCÍCIO 2: CALCULADORA ===");
// Métodos de instância
Calculadora calc = new Calculadora();
Console.WriteLine($"Soma (10 + 5): {calc.Somar(10, 5)}");
Console.WriteLine($"Subtração (10 - 5): {calc.Subtrair(10, 5)}");
Console.WriteLine($"Multiplicação (10 * 5): {calc.Multiplicar(10, 5)}");

// Método estático executado diretamente pela classe
double resultadoDivisao = Calculadora.Dividir(20, 4);
Console.WriteLine($"Divisão estática (20 / 4): {resultadoDivisao}");

Console.WriteLine("\n=== EXERCÍCIO 3: VALIDAÇÃO DE VELOCIDADE ===");
Veiculo carro = new Veiculo();

Console.WriteLine("Tentando atribuir 50 km/h...");
carro.Velocidade = 50;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

Console.WriteLine("\nTentando atribuir 250 km/h (inválido)...");
carro.Velocidade = 250;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

Console.WriteLine("\nTentando atribuir -20 km/h (inválido)...");
carro.Velocidade = -20;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

Console.WriteLine("\nTentando atribuir 180 km/h...");
carro.Velocidade = 180;
Console.WriteLine($"Velocidade atual: {carro.Velocidade} km/h");

Console.WriteLine("\n=== EXERCÍCIO 4: FUNCIONÁRIO E CONTROLE DE ACESSO ===");
Funcionario func = new Funcionario("Roberto Santos", "Desenvolvedor", 5000.00m);

func.ConsultarSalario();
func.AumentarSalario(10); // Aumento de 10%
func.ConsultarSalario();


Console.WriteLine("\n=== EXERCÍCIO 5: CONSTRUTORES E SOBRECARGA DE LIVROS ===");
Livro l1 = new Livro();
Livro l2 = new Livro("O Senhor dos Anéis");
Livro l3 = new Livro("1984", "George Orwell");
Livro l4 = new Livro("Dom Casmurro", "Machado de Assis", 256);

l1.ExibirDados();
l2.ExibirDados();
l3.ExibirDados();
l4.ExibirDados();