using Entrega2_2.src;

Juego juego = new Juego();

AJugadore Santiago = new Jugador ("Santiago","pivote",10);
AJugadore Carlos = new Jugador ("Carlos","centro",7);
AJugadore Camila = new Jugador ("Camila","tapon",7);
AJugadore Mariana = new Jugador ("Mariana","alero",8);
AJugadore Sebastian = new Jugador ("Sebastian","ala-pivot",9);
AJugadore Camilo = new Jugador ("Camilo","pivote",8);
AJugadore Carlito = new Jugador ("Carlito","pivote",5);

juego.addJugadores(Santiago);
juego.addJugadores(Carlos);
juego.addJugadores(Camila);
juego.addJugadores(Mariana);
juego.addJugadores(Sebastian);
juego.addJugadores(Camilo);
juego.addJugadores(Carlito);

juego.Partido();

