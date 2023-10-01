namespace Entrega2.src;

    public abstract class APokemon : IPokemon
{
    private string Nombre { get; set; }
    private string Tipo { get; set; }
    private List <int> Ataque = new List<int>();
    private int Defensa { get; set; }


    public APokemon(string Nombre, string Tipo,List<int>Ataque,int Defensa)
    {
        this.Nombre = Nombre;
        this.Tipo = Tipo;
        this.Ataque = Ataque;
        this.Defensa = Defensa;
    }

    public string getNombre(){
        return this.Nombre;
    }
    public string getTipo(){
        return this.Tipo;
    }
    public List<int> getAtaque(){
        return this.Ataque;
    }
    public int getDefensa(){
        return this.Defensa;
    }
}