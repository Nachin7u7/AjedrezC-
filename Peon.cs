using System;

namespace helloWorld
{
	public class Peon : PiezaAjedrez
	{
		bool peon;
		public bool firstMove = true;
		public Peon (int mov,int comidas,int posX, int posY, string color, bool peon) //:base(mov,comidas,posX,posY,color)
		{
			this.posX = posX;
			this.posY = posY;
			this.peon = peon;
			//super()
		}
		bool isPeon(){
			return peon;
		}

		void setPeon(bool newPeon){
			peon = newPeon;
		}

		bool getFirstMove(){
			return firstMove;
		}

		public void setMov(string destino){
			if (!this.getFirstMove ()) {
				moverPieza (destino, 1);
			} else {
				moverPieza (destino, 2);
			}
		}

		public void moverPieza(string destino, int numCasillas){
			
		}

	}
}

