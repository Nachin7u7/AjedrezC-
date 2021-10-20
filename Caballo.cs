using System;

namespace helloWorld
{
	public class Caballo//:PiezaAjedrez
	{

		bool saltar;

		public Caballo ( bool saltar)//: base(mov,comidas,posX,posY,color)
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

