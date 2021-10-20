using System;

namespace helloWorld
{
	public class Rey//:PiezaAjedrez
	{
		bool rey;
		public Rey (bool rey)//: base(mov,comidas,posX,posY,color)
		{
			this.rey = rey;
		}

		bool isRey(){
			return rey;
		}

		void setRey(bool newRey){
			rey = newRey;
		}
	}
}

