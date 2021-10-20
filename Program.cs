using System;

namespace helloWorld
{
	class MainClass
	{



		public static void Main (string[] args)
		{
			PiezaAjedrez[,] cuadros = new PiezaAjedrez[8, 8];
			Tablero tablero = new Tablero(cuadros);

			// piezaAjedrez > peon

			Peon pb1 = new Peon (1,1,0,1,"Black",true);
			Peon pb2 = new Peon (1,1,1,1,"Black",true);
			Peon pb3 = new Peon (1,1,2,1,"Black",true);
			Peon pb4 = new Peon (1,1,3,1,"Black",true);
			Peon pb5 = new Peon (1,1,4,1,"Black",true);
			Peon pb6 = new Peon (1,1,5,1,"Black",true);
			Peon pb7 = new Peon (1,1,6,1,"Black",true);
			Peon pb8 = new Peon (1,1,7,1,"Black",true);

			Peon pw1 = new Peon (1,1,0,6,"White",true);
			Peon pw2 = new Peon (1,1,1,6,"White",true);
			Peon pw3 = new Peon (1,1,2,6,"White",true);
			Peon pw4 = new Peon (1,1,3,6,"White",true);
			Peon pw5 = new Peon (1,1,4,6,"White",true);
			Peon pw6 = new Peon (1,1,5,6,"White",true);
			Peon pw7 = new Peon (1,1,6,6,"White",true);
			Peon pw8 = new Peon (1,1,7,6,"White",true);




			Console.WriteLine(pb1.getPosX() +" "+ pb1.getPosY());

			tablero.setPiece(pb1); 

			pb1.setName ("Pucho");

			tablero.showPiece (0, 1); //PUCHO

		}
	}
}
