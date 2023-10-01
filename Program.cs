using Entrega2.src;

List<int> AtaPoke1 = new List<int> {20,10,10};
APokemon Pokemon1 = new Pokemon ("Pikachu", "Electrico",AtaPoke1,10);

List<int> AtaPoke2 = new List<int> {10,10,10};
APokemon Pokemon2 = new Pokemon("Charizard","Fuego",AtaPoke2,10);

int SimularBatalla(IPokemon P1, IPokemon P2)
{
    int PuntosP1 = 0;
    int PuntosP2 = 0;

    for (int turno = 1; turno <= 3; turno++)
    {
        List<int> AtaquesP1 = P1.getAtaque();
        int AtaqP1 = AtaquesP1[new Random().Next(AtaquesP1.Count)];
        int DefensaP2 = P2.getDefensa();

        List<int> AtaquesP2 = P2.getAtaque();
        int AtaqP2 = AtaquesP2[new Random().Next(AtaquesP2.Count)];
        int DefensaP1 = P1.getDefensa();

        int dañoP1 = AtaqP1 - DefensaP2;
        int dañoP2 = AtaqP2 - DefensaP1;

        if (dañoP1 > dañoP2)
        {
            PuntosP1++; 
        }
        else if (dañoP2 > dañoP1)
        {
            PuntosP2++; 
        }
    }

    if (PuntosP1 > PuntosP2)
    {
        return 1;
    }
    else if (PuntosP2 > PuntosP1)
    {
        return 2; 
    }
    else
    {
        return 0;
    }
}

Console.WriteLine($"------Batalla principal entre {Pokemon1.getNombre()} y {Pokemon2.getNombre()}------");
Console.WriteLine("///////////////////////////////////////////////////////////////");
int resultado = SimularBatalla(Pokemon1, Pokemon2);

// Determinar el resultado
if (resultado == 0)
{
    Console.WriteLine($"{Pokemon1.getNombre()} y {Pokemon2.getNombre()} Han quedo empatado");
}
else if (resultado == 1)
{
    Console.WriteLine($"{Pokemon1.getNombre()} Ganador de la batalla");
}
else
{
    Console.WriteLine($"{Pokemon2.getNombre()} Ganador de la batalla");
}
