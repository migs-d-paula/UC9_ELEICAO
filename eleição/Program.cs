int lula = 0, bolsonaro = 0, daciolo = 0, marina = 0, conta;
double porc_lula, porc_bolsonaro, porc_daciolo, porc_marina;
string letra , resposta = "S";

while (resposta == "s" || resposta == "S") 
{
    Console.Clear();

    Console.WriteLine("Digite L para Lula");
    Console.WriteLine("Digite B para Bolsonaro");
    Console.WriteLine("Digite D para Daciolo");
    Console.WriteLine("Digite M para Marina");

    letra = Console.ReadLine();

    if (letra == "L" || letra == "l")
    {
        lula++;
    }

    if (letra == "B" || letra == "b")
    {
        bolsonaro++;
    }

    if (letra == "D" || letra == "d")
    {
        daciolo++;
    }

    if (letra == "M" || letra == "m")
    {
        marina++;
    }
    Console.Clear();
    Console.WriteLine("Caso queira continuar votando digite S");
    resposta = Console.ReadLine();
}

conta = lula + bolsonaro + daciolo + marina;

Console.Clear();

Console.WriteLine("O total de votos de cada candidato foi:" + conta + "\n\n");


Console.WriteLine("Lula com:" + lula);
Console.WriteLine("Bolsonaro com:" + bolsonaro);
Console.WriteLine("Daciolo com:" + daciolo);
Console.WriteLine("Marina com:" + marina);

Console.WriteLine("para saber a porcentagem digite qualquer tecla");
Console.ReadLine();

Console.Clear();


porc_lula = (lula * 100) / conta;
porc_bolsonaro = (bolsonaro * 100) / conta;
porc_daciolo = (daciolo * 100) / conta;
porc_marina = (marina * 100) / conta;

Console.WriteLine("Lula com:" + porc_lula + "%");
Console.WriteLine("Bolsonaro com:" + porc_bolsonaro + "%");
Console.WriteLine("Daciolo com:" + porc_daciolo + "%");
Console.WriteLine("Marina com:" + porc_marina + "%");