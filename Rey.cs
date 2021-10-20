using System;

namespace helloWorld
{
	public class Rey:PiezaAjedrez
	{
		bool rey;
		public Rey (bool rey)
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

