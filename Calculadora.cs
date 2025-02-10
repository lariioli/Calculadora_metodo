using Layout;

namespace Calculadora
{
   class Operacoes
   {
      public static decimal ObterValores()
      {
      repetir:
          Formatacao.Cor("\nInforme o valor: ", ConsoleColor.Cyan);
          Console.ForegroundColor = ConsoleColor.Magenta;
          string input = Console.ReadLine();
          Console.ResetColor(); 

          if (!decimal.TryParse(input, out decimal valor))
          {
            Formatacao.Cor("Valor inválido!\n", ConsoleColor.Red);
            goto repetir;
          }
            return valor;
      }
      public static void RealizarAdicao(decimal valor1, decimal valor2)
      {
        MostrarResultado("soma", valor1, valor2, valor1 + valor2);
      }
      public static void RealizarSubtracao(decimal valor1, decimal valor2)
      {
        MostrarResultado("subtração", valor1, valor2, valor1 - valor2);
      }
      public static void RealizarMultiplicacao(decimal valor1, decimal valor2)
      {
        MostrarResultado("multiplicação", valor1, valor2, valor1 * valor2);
      }
      public static void RealizarDivisao(decimal valor1, decimal valor2)
      {
        if (valor2 == 0)
        {
          Formatacao.Cor("Erro: Divisão por zero!/n", ConsoleColor.Red);
          return;
        }
          MostrarResultado("divisão", valor1, valor2, valor1 / valor2);
      }
      private static void MostrarResultado(string operacao, decimal valor1, decimal valor2, decimal resultado)
      {
        Formatacao.Cor($"O resultado da {operacao} ", ConsoleColor.Cyan);
        Formatacao.Cor($"de ", ConsoleColor.Cyan);
        Formatacao.Cor($"{valor1} ", ConsoleColor.Magenta);
        Formatacao.Cor($"e ", ConsoleColor.Cyan);
        Formatacao.Cor($"{valor2} ", ConsoleColor.Magenta);
        Formatacao.Cor($"é ", ConsoleColor.Cyan);
        Formatacao.Cor($"{resultado}\n", ConsoleColor.Magenta);
      }
   }

}
