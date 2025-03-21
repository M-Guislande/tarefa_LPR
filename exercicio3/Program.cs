
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----------------------------");
Console.WriteLine("Desenvolva o seu personagem!!");
Console.WriteLine("-----------------------------");
Console.WriteLine("ESCOLHA SUA CLASSE:\nGuerreira\nMago\nArqueira");

string classe = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Red;
if(classe=="Guerreira" || classe=="guerreira")
{

    Console.WriteLine("Escolha o numero da sua habilidade:\n1-Ataque pesado\n2-Defesa total");
    int habilidade = int.Parse(Console.ReadLine());
    switch (habilidade)
    {
        case 1:
            Console.WriteLine("Ola GUERREIRA sua habilidade é de ataque pesado");
            break;
        case 2:
            Console.WriteLine("Ola GUERREIRA sua habilidade é de defesa total");
            break;
    }
}
if(classe=="Mago" ||classe=="mago" )
{
    Console.WriteLine("Escolha o numero da sua habilidade:\n1-Bola de fogo\n2-Escudo de gelo");
    int habilidade = int.Parse(Console.ReadLine());
    switch (habilidade)
    {
        case 1:
            Console.WriteLine("Ola MAGO sua habilidade é Bola de fogo");
            break;
        case 2:
            Console.WriteLine("Ola MAGO sua habilidade é Escudo de gelo");
            break;
    }
}
if(classe=="Arqueiro" || classe=="arqueiro")
{
    Console.WriteLine("Escolha o numero da sua habilidade:\n1-Flecha Precisa\n2-Disparo Triplo");
    int habilidade = int.Parse(Console.ReadLine());
    switch (habilidade)
    {
        case 1:
            Console.WriteLine("Ola ARQUEIRO sua habilidade é de Flecha Precisa");
            break;
        case 2:
            Console.WriteLine("Ola ARQUEIRO sua habilidade é de Disparo Triplo");
            break;
    }
}    Console.ResetColor();
