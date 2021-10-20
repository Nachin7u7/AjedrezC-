using System;

namespace helloWorld
{
	public class Peon : PiezaAjedrez
	{
		bool peon;

		public Peon (bool peon) : base()
		{
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

