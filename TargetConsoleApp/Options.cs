using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetConsoleApp
{
    internal class Options
    {
        public static string InicarTela()
        {
            string opacaoUsuario;
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção!");
            Console.WriteLine("1 - Para primeira solução.");
            Console.WriteLine("2 - Para segundo solução.");
            Console.WriteLine("3 - Para terceira solução.");
            Console.WriteLine("4 - Para quarta solução.");
            Console.WriteLine("5 - Para quinta solução.");
            Console.WriteLine("0 - Sair da aplicação.\n\n\n");
            opacaoUsuario = Console.ReadLine();
            return opacaoUsuario;
        }
        public static void SolucionarPrimeira()
        {
            Console.WriteLine("Loop de \"while\" da resolução do problema 1\n");
            int indice = 13;
            int soma = 0;
            int k = 0;
            //Primeiro método
            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine($"Valor de soma utlizando o primeiro método = {soma}\n");
            //Segundo méotodo
            soma = 0;
            k = 0;
            Console.WriteLine("Utilizando o \"do while\" para a resolução do problema 1 como forma alternativa\n");
            do
            {
                k = k + 1;
                soma = soma + k;
            }
            while (k < indice);
            Console.WriteLine($"Valor de soma utilizando o segundo método = {soma}\n");
        }
        public static void SolucionarSegunda()
        {
            Console.WriteLine("Iniciando a resolução do segundo problema");
            Console.WriteLine("Vamos verificar se o numero pertence a sequência de Fibonacci, Insira um valor:");
            var entradaFibo = Console.ReadLine();
            bool sucesso = int.TryParse(entradaFibo, out var numeroFibo);
            if (sucesso)
            {
                int a = 0;
                int b = 1;
                int c = a + b;
                Console.WriteLine("Sequência de Fibonacci:");
                while (c < numeroFibo)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.WriteLine(c);
                }

                if (c != numeroFibo)
                    Console.WriteLine($"O numero {numeroFibo} não pertence a sequencia!\n");
                else
                    Console.WriteLine($"O numero {numeroFibo} pertence a sequencia!\n");
            }
            else
            {
                Console.WriteLine("Insira um valor numérico inteiro válido\n\n\n");
            }
        }
        public static void SolucionarQuarta()
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double total = sp + rj + mg + es + outros;

            double percentualSP = (sp / total) * 100;
            double percentualRJ = (rj / total) * 100;
            double percentualMG = (mg / total) * 100;
            double percentualES = (es / total) * 100;
            double percentualOutros = (outros / total) * 100;

            Console.WriteLine($"Percentual de representação de SP: {percentualSP:F2}%");
            Console.WriteLine($"Percentual de representação de RJ: {percentualRJ:F2}%");
            Console.WriteLine($"Percentual de representação de MG: {percentualMG:F2}%");
            Console.WriteLine($"Percentual de representação de ES: {percentualES:F2}%");
            Console.WriteLine($"Percentual de representação de Outros: {percentualOutros:F2}%");
        }
        public static void SolucionarQuinta()
        {
            Console.WriteLine("Escreva a string que deseja inverter: \n");
            var original = Console.ReadLine();

            Console.WriteLine($"String original: {original}");

            char[] caracteresInvertidos = new char[original.Length];
            int j = 0;

            for (int i = original.Length - 1; i >= 0; i--)
            {
                caracteresInvertidos[j] = original[i];
                j++;
            }

            string invertida = new string(caracteresInvertidos);

            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}
