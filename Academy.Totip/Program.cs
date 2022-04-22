// See https://aka.ms/new-console-template for more information

using Academy.Common.Constants;
using Academy.Common.Helpers;

Console.WriteLine(CommonConstants.AcademyName);

Console.WriteLine("Calcolo Vittoria\r\n");


Console.WriteLine("Inserisci goal prima squadra");

int a = GetNumber();


Console.WriteLine("Inserisci goal seconda squadra");

int b = GetNumber();



//esito con funzione:
string result = ResultHelper.GetEsito(a, b);
Console.WriteLine("Vittoria: " + result);
//oppure
//esito con procedura:
Esito(a, b);


Console.ReadKey();


static void Esito(int a, int b)
{
    var result = ResultHelper.GetEsito(a, b);
    Console.WriteLine("Vittoria: " + result);
}

static int GetNumber()
{
    var inputString = Console.ReadLine();
    int result = Convert.ToInt32(inputString);
    return result;
}