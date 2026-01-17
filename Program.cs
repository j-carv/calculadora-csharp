using Calculadora;
namespace MeuApp
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Escolha a operacao: Paridade, Soma, Subtracao, Multiplicacao, Divisao");
            var operacao = Console.ReadLine();

            if (operacao == "Paridade") {
                var calc = new Operacoes();
                Console.WriteLine("Digite um numero para ver se e par...");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O Resultado de {numero1} é : " + 
                (calc.ParImpar(numero1) == 0 ? "Par" : "Impar"));
            }
            else if (operacao == "Soma")
            {
                var calc = new Soma();
                Console.WriteLine("Digite o Primeiro número...");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o Segundo número...");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O Resultado de {numero1} + {numero2} é: " +calc.Somar(numero1, numero2));
            }
            else if (operacao == "Subtracao")
            {
                var calc = new Subtracao();
                Console.WriteLine("Digite o Primeiro numero...");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero...");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O resultado de {numero1} - {numero2} é: " + calc.Subtrair(numero1, numero2));
            }
            else if (operacao == "Multiplicacao") 
            {
                var calc = new Multiplicacao();
                Console.WriteLine("Digite o primeiro numero...");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero...");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O resultado de {numero1} * {numero2} é: " + calc.Multiplicar(numero1, numero2));
            }
            else if (operacao == "Divisao")
            {
                var calc = new Divisao();
                Console.WriteLine("Digite o primeiro numero...");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero...");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"O resultado de {numero1} / {numero2} é: " + calc.Dividir(numero1, numero2));
            }
            Main();
        }
        
    }
}
