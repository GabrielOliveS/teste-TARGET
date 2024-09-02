using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TargetConsoleApp
{
    public class Faturamentos
    {
        public int Dia { get; set; }
        public double Faturamento { get; set; }

        public static void SolucionarTerceira()
        {
            // Carregar o arquivo JSON
            string json = File.ReadAllText("setembro.json");
            var faturamentos = JsonConvert.DeserializeObject<List<Faturamentos>>(json);

            // Filtra os dias com faturamento maior que 0
            var diasComFaturamento = faturamentos.Where(f => f.Faturamento > 0).ToList();

            // Calcula o menor e o maior valor de faturamento
            double menorFaturamento = diasComFaturamento.Min(f => f.Faturamento);
            double maiorFaturamento = diasComFaturamento.Max(f => f.Faturamento);

            // Calcula a média mensal
            double mediaMensal = diasComFaturamento.Average(f => f.Faturamento);

            // Calcula o número de dias em que o faturamento foi superior à média mensal
            int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Faturamento > mediaMensal);

            // Exibe os resultados
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        }

    }

}
