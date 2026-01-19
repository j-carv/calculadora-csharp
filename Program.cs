using Calculadora;
namespace MeuApp
{
    class Program
    {
        static void Main()
        {
            static long LerNumero(string mensagem)
            {
                Console.WriteLine(mensagem);
                return Convert.ToInt64(Console.ReadLine());
            }
            while (true) {
                Console.WriteLine("Escolha a operacao: Paridade, Soma, Subtracao, Multiplicacao, Divisao");
                var operacao = Console.ReadLine();
                operacao = operacao?.Trim().ToLower();
            switch (operacao) 
            {
                case "paridade":
                    {
                        var calc = new Paridade();
                        long numero = LerNumero("Digite um numero para verificar paridade...");
                        Console.WriteLine($"O Resultado de {numero} é : " + (calc.ParImpar(numero) == 0 ? "Par" : "Impar"));
                        break;
                    }
                case "soma":
                    {
                        var calc = new Soma();
                        long numero1 = LerNumero("Digite o primeiro numero...");
                        long numero2 = LerNumero("Digite o segundo numero...");
                        Console.WriteLine($"O Resultado de {numero1} + {numero2} é: " + calc.Somar(numero1, numero2));
                        break;
                    }
                case "subtracao":
                    {
                        var calc = new Subtracao();
                        long numero1 = LerNumero("Digite o primeiro numero...");
                        long numero2 = LerNumero("Digite o segundo numero...");
                        Console.WriteLine($"O resultado de {numero1} - {numero2} é: " + calc.Subtrair(numero1, numero2)); 
                        break;
                    }
                case "multiplicacao":
                    {
                        var calc = new Multiplicacao();
                        long numero1 = LerNumero("Digite o primeiro numero...");
                        long numero2 = LerNumero("Digite o segundo numero...");
                        Console.WriteLine($"O resultado de {numero1} * {numero2} é: " + calc.Multiplicar(numero1, numero2));
                        break;
                    }
                case "divisao":
                    {
                        var calc = new Divisao();
                        long numero1 = LerNumero("Digite o primeiro numero...");
                        long numero2 = LerNumero("Digite o segundo numero...");
                        Console.WriteLine($"O resultado de {numero1} / {numero2} é: " + calc.Dividir(numero1, numero2));
                        break;
                    }
                default:
                    break;
                }
            }
        }
    }
}
