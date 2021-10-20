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

		public void preguntarDestino(PiezaAjedrez pieza, string destino){ //5A
			
			char[] charArray = destino.ToCharArray();
			char num = charArray[0]; //5
			Console.WriteLine(num);
			char caracter = charArray[1]; //A

			if (caracter == 'A') {
				moverPieza (pieza, num, 0);
			} else if (caracter == 'B') {
				moverPieza(pieza, num, 1);
			} else if (caracter == 'C') {
				moverPieza(pieza, num, 2);
			} else if (caracter == 'D') {
				moverPieza(pieza, num, 3);
			} else if (caracter == 'E') {
				moverPieza(pieza, num, 4);
			} else if (caracter == 'F') {
				moverPieza(pieza, num, 5);
			} else if (caracter == 'G') {
				moverPieza(pieza, num, 6);
			} else if (caracter == 'H') {
				moverPieza(pieza, num, 7);
			}

		}

		public void moverPieza(PiezaAjedrez pieza, char x, int y){
			Console.WriteLine (x);
			pieza.setPosX (x);
			pieza.setPosY (y);
		}

	}
}

