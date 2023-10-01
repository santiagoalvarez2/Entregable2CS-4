using System.Runtime.CompilerServices;

namespace Entrega2_2.src;

public class Jugador : AJugadore
{
   public Jugador(string Nombre, string Posicion, int Rendimiento):base(Nombre,Posicion,Rendimiento){}
}
public  class Juego
{  
   private List <AJugadore> jugadores = new List <AJugadore>();
    public void addJugadores(AJugadore jugador)   
   {
      if (jugadores.Count < 6)
      {
         jugadores.Add(jugador);
      }else {
         Console.WriteLine("Limite de jugadores");
      }
   }
   public void Partido (){
      if (jugadores.Count < 6){
        Console.WriteLine("Jugadores insuficientes");
        return;
      }
      
      Random EliEquipo = new Random();
      List<AJugadore> Equipo1 = new List<AJugadore>();
      List<AJugadore> Equipo2 = new List<AJugadore>();

      while (jugadores.Count > 0){
         int RanEquipo = EliEquipo.Next(jugadores.Count);
         if(Equipo1.Count < 3){
            Equipo1.Add(jugadores[RanEquipo]);
         }else{
            Equipo2.Add(jugadores[RanEquipo]);
         }
         jugadores.RemoveAt(RanEquipo);
      }
         int RenEquipo1 = Equipo1.Sum (jugadores =>jugadores.getRendimiento());
         int RenEquipo2 = Equipo2.Sum (jugadores =>jugadores.getRendimiento());;
      
      Console.WriteLine("Equipo1");
      foreach (AJugadore jugador in Equipo1)
      {
         Console.WriteLine($"Nombre: {jugador.getNombre()} Posicion: {jugador.getPosicion()} Rendimiento {jugador.getRendimiento()}");
      }
      Console.WriteLine("Equipo2");
      foreach (AJugadore jugador in Equipo2)
      {
         Console.WriteLine($"Nombre: {jugador.getNombre()} Posicion: {jugador.getPosicion()} Rendimiento {jugador.getRendimiento()}");
      }
      if (RenEquipo1 > RenEquipo2)
      {
         Console.WriteLine("Equipo 1 ganador del partido");
      }else if (RenEquipo2 > RenEquipo1)
      {
         Console.WriteLine("Equipo 2 ganador del partido");
      }else
      {
         Console.WriteLine("Empate");
      }
      }
}
