using Newtonsoft.Json;

namespace Desafio
{
    public class Questoes
    {

        static void Main(string[] args)
        {
            Questao01();
            Questao02();
            Questao03();
            Questao04();
            Questao05();
        }

        static bool VerificaFibonacci(int numero)
        {
            int a = 0, b = 1, c = 0;

            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == numero;
        }
        public class Faturamento
        {
            public int Dia { get; set; }
            public double Valor { get; set; }
        }

        static string InverterString(string str)
        {
            char[] arr = str.ToCharArray();
            int inicio = 0;
            int fim = arr.Length - 1;

            while (inicio < fim)
            {
                char temp = arr[inicio];
                arr[inicio] = arr[fim];
                arr[fim] = temp;

                inicio++;
                fim--;
            }

            return new string(arr);
        }

        //Calcular o valor da variável
        public static void Questao01() 
        {
            Console.WriteLine("Questão 01");
            int INDICE = 13, SOMA = 0, K = 0;
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine("O valor de SOMA é: " + SOMA);

        }

        //Verificar se um número informado pertence à sequência de Fibonacci
        public static void Questao02() 
        {
            Console.Write("Questão 02 ");
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            bool pertenceFibonacci = VerificaFibonacci(numero);
            if (pertenceFibonacci)
                Console.WriteLine("O número pertence à sequência de Fibonacci.");
            else
                Console.WriteLine("O número não pertence à sequência de Fibonacci.");
        }

        //Cálculo de faturamento diário e análise dos dados
        public static void Questao03() 
        {
            Console.WriteLine("Questão 03");
            string json = @"
            [
                {""Dia"": 1, ""Valor"": 31490.7866},
                {""Dia"": 2, ""Valor"": 37277.9400},
                {""Dia"": 3, ""Valor"": 37708.4303},
                {""Dia"": 4, ""Valor"": 0},
                {""Dia"": 5, ""Valor"": 0},
                {""Dia"": 6, ""Valor"": 17934.2269},
                {""Dia"": 7, ""Valor"": 0},
                {""Dia"": 8, ""Valor"": 6965.1262},
                {""Dia"": 9, ""Valor"": 24390.9374},
                {""Dia"": 10, ""Valor"": 14279.6481},
                {""Dia"": 11, ""Valor"": 0},
                {""Dia"": 12, ""Valor"": 0},
                {""Dia"": 13, ""Valor"": 39807.6622},
                {""Dia"": 14, ""Valor"": 27261.6304},
                {""Dia"": 15, ""Valor"": 39775.6434},
                {""Dia"": 16, ""Valor"": 29797.6232},
                {""Dia"": 17, ""Valor"": 17216.5017},
                {""Dia"": 18, ""Valor"": 0},
                {""Dia"": 19, ""Valor"": 0},
                {""Dia"": 20, ""Valor"": 12974.2000},
                {""Dia"": 21, ""Valor"": 28490.9861},
                {""Dia"": 22, ""Valor"": 8748.0937},
                {""Dia"": 23, ""Valor"": 8889.0023},
                {""Dia"": 24, ""Valor"": 17767.5583},
                {""Dia"": 25, ""Valor"": 0},
                {""Dia"": 26, ""Valor"": 0},
                {""Dia"": 27, ""Valor"": 3071.3283},
                {""Dia"": 28, ""Valor"": 48275.2994},
                {""Dia"": 29, ""Valor"": 10299.6761},
                {""Dia"": 30, ""Valor"": 39874.1073}
            ]";
            var faturamento = JsonConvert.DeserializeObject<Faturamento[]>(json);

            var diasComFaturamento = faturamento.Where(f => f.Valor > 0).ToList();
            double media = diasComFaturamento.Average(f => f.Valor);
            int diasAcimaMedia = diasComFaturamento.Count(f => f.Valor > media);

            var menorFaturamento = diasComFaturamento.Min(f => f.Valor);
            var maiorFaturamento = diasComFaturamento.Max(f => f.Valor);

            Console.WriteLine($"Menor faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias acima da média: {diasAcimaMedia}");
        }

        //Cálculo percentual de representação de cada estado
        public static void Questao04() 
        {
            Console.WriteLine("Questão 04");
            double total = 67836.43 + 36678.66 + 29229.88 + 27165.48 + 19849.53;

            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            Console.WriteLine($"Percentual de SP: {(sp / total) * 100}%");
            Console.WriteLine($"Percentual de RJ: {(rj / total) * 100}%");
            Console.WriteLine($"Percentual de MG: {(mg / total) * 100}%");
            Console.WriteLine($"Percentual de ES: {(es / total) * 100}%");
            Console.WriteLine($"Percentual de Outros: {(outros / total) * 100}%");
        }

        //inverte uma String
        public static void Questao05() 
        {
            Console.WriteLine("Questão 05");
            Console.Write("Informe uma string: ");
            string input = Console.ReadLine();
            string invertida = InverterString(input);
            Console.WriteLine("String invertida: " + invertida);
        }

    }
}
