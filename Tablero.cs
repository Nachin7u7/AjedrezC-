using System;

namespace helloWorld
{
	public class Tablero
	{

		PiezaAjedrez[,] tablero = new PiezaAjedrez[8,8];


		public Tablero (PiezaAjedrez[,] tablero) //1,2,3,4,5,6,7,8
							   		  //a,b,c,d,e,f,g,h
		{
			this.tablero = tablero;
		}
			
		public void setPiece(PiezaAjedrez pieza){
			tablero [pieza.getPosX (), pieza.getPosY()] = pieza;
		}

		public void showPiece(int x, int y){
			Console.WriteLine (tablero [x, y].getName()); //Print, System.out.print()
		}

	}
}

