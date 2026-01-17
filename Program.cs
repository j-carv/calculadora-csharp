using Calculadora;
namespace MeuApp
{
    class Program
    {
        static void Main() // UTILIZAR SWITCHES CASE, MELHORAR EXECUCAO
        {
            static int LerNumero(string mensagem)
            {
                Console.WriteLine(mensagem);
                return Convert.ToInt32(Console.ReadLine());
            }
            while (true) {
            Console.WriteLine("Escolha a operacao: Paridade, Soma, Subtracao, Multiplicacao, Divisao");
            var operacao = Console.ReadLine();

            if (operacao == "Paridade") {
                var calc = new Operacoes();
                int numero = LerNumero("Digite um numero para verificar paridade...");
                Console.WriteLine($"O Resultado de {numero} é : " + 
                (calc.ParImpar(numero) == 0 ? "Par" : "Impar"));
            }
            else if (operacao == "Soma")
            {
                var calc = new Soma();
                int numero1 = LerNumero("Digite o primeiro numero...");
                int numero2 = LerNumero("Digite o segundo numero...");
                Console.WriteLine($"O Resultado de {numero1} + {numero2} é: " +calc.Somar(numero1, numero2));
            }
            else if (operacao == "Subtracao")
            {
                var calc = new Subtracao();
                int numero1 = LerNumero("Digite o primeiro numero...");
                int numero2 = LerNumero("Digite o segundo numero...");
                Console.WriteLine($"O resultado de {numero1} - {numero2} é: " + calc.Subtrair(numero1, numero2));
            }
            else if (operacao == "Multiplicacao") 
            {
                var calc = new Multiplicacao();
                int numero1 = LerNumero("Digite o primeiro numero...");
                int numero2 = LerNumero("Digite o segundo numero...");
                Console.WriteLine($"O resultado de {numero1} * {numero2} é: " + calc.Multiplicar(numero1, numero2));
            }
            else if (operacao == "Divisao")
            {
                var calc = new Divisao();
                int numero1 = LerNumero("Digite o primeiro numero...");
                int numero2 = LerNumero("Digite o segundo numero...");
                Console.WriteLine($"O resultado de {numero1} / {numero2} é: " + calc.Dividir(numero1, numero2));
            }
            else 
            {
                Console.WriteLine("Operacao invalida. Tente novamente.");
            }
            }
        }
    }
}
