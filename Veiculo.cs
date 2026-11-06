using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPoo
{
    public class Veiculo
    {
        private double _velocidade;

    public double Velocidade
    {
        get => _velocidade;
        set
        {
            // Apenas aceita valores entre 0 e 200 km/h
            if (value >= 0 && value <= 200)
            {
                _velocidade = value;
            }
            else
            {
                Console.WriteLine($"Atribuição inválida ({value} km/h). A velocidade deve estar entre 0 e 200 km/h.");
            }
        }
    }
    }
}