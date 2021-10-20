using System;

namespace helloWorld
{
	public class Peon : PiezaAjedrez
	{
		bool peon;

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

	}
}

