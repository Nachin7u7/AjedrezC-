using System;

namespace helloWorld
{
	public class Caballo:PiezaAjedrez
	{

		bool saltar;

		public Caballo ( bool saltar):base()
		{
			this.saltar = saltar;
		}

		bool isCaballo(){
			return saltar;
		}
	
		void setCaballo(bool newCaballo){
			saltar = newCaballo;
		}
	}
}

