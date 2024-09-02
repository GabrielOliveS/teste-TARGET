using System.ComponentModel;
using TargetConsoleApp;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Iniciando teste de estágio da Target");
Console.ResetColor();
string opacaoUsuario = "99";
do
{
    opacaoUsuario = Options.InicarTela();
    switch (opacaoUsuario)
    {
        case "1":
            Options.SolucionarPrimeira();
            break;
        case "2":
            Options.SolucionarSegunda();
            break;
        case "3":
            Faturamentos.SolucionarTerceira();
            break;
        case "4":
            Options.SolucionarQuarta();
            break;
        case "5":
            Options.SolucionarQuinta();
            break;

        default:
            Console.WriteLine("Selecione uma opção válida!\n\n\n");
            break;
    }

} while (opacaoUsuario != "0");

