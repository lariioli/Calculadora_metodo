using Calculadora;
using Layout;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Formatacao.Cor("Escolha uma operação:\n", ConsoleColor.Cyan);
            Formatacao.Cor("1 - Adição\n", ConsoleColor.Magenta);
            Formatacao.Cor("2 - Subtração\n", ConsoleColor.Magenta);
            Formatacao.Cor("3 - Multiplicação\n", ConsoleColor.Magenta);
            Formatacao.Cor("4 - Divisão\n", ConsoleColor.Magenta);
            Formatacao.Cor("0 - Sair\n", ConsoleColor.Magenta);
            Formatacao.Cor("Opção:\n", ConsoleColor.Cyan);
            Console.ForegroundColor = ConsoleColor.Magenta;
            string opcao = Console.ReadLine();
            Console.ResetColor();
            if (opcao == "0")
            {
                Formatacao.Cor("\nSaindo da Calculdora\n", ConsoleColor.Green); 
                break;
            }
            decimal valor1 = Operacoes.ObterValores();
            decimal valor2 = Operacoes.ObterValores();
            
            switch (opcao)
            {
                case "1":
                Operacoes.RealizarAdicao(valor1, valor2);
                break;
                case "2":
                Operacoes.RealizarSubtracao(valor1, valor2);
                break;
                case "3":
                Operacoes.RealizarMultiplicacao(valor1, valor2);
                break;
                case "4":
                Operacoes.RealizarDivisao(valor1, valor2);
                break;
                default:

                Formatacao.Cor("Opção inválida! Tente novamente.\n", ConsoleColor.Red);
                break;
            }
            Formatacao.Cor("\nPressione qualquer tecla para continuar... ", ConsoleColor.Green);
            Console.ReadKey();
        }
    }
}

