using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme fil = new Filme();
            Entrada ent = new Entrada();

            Console.Write("Digite o titulo do filme: ");
            fil.SetTitulo(Console.ReadLine());
            Console.Write("Digite a sinopse do filme: ");
            fil.SetSinopse(Console.ReadLine());
            Console.Write("Digite o genero do filme: ");
            fil.SetGenero(Console.ReadLine());
            Console.Write("Digite a classificação do filme: ");
            fil.SetClassificacao(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite o valor: ");
            ent.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o local da poltrona: ");
            ent.SetPoltrona(Console.ReadLine());
            Console.Write("Digite a data do filme: ");
            ent.SetDta(Console.ReadLine());
            Console.Write("Digite o horario do filme: ");
            ent.SetHora(Console.ReadLine());

            Console.WriteLine("\n---------- Ingresso ----------");
            Console.WriteLine("Titulo: " + fil.GetTitulo() + "\nSinopse: " + fil.GetSinopse() + "\nGenero: " + fil.GetGenero() +
                "\nClassificação: " + fil.GetClassificacao() + "\nPoltrona: " + ent.GetPoltrona() + "\nHorario: " + ent.GetHora() + 
                "\nData: " + ent.GetDta() + "\nValor" + ent.GetValor().ToString("C"));
            Console.WriteLine("------------------------------");

            Console.ReadKey();
        }
    }
}
