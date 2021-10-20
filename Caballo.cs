using System;

namespace helloWorld
{
	public class Caballo:PiezaAjedrez
	{
		int mov;
		int comidas;
		bool saltar;

		public Caballo (int mov, int comidas, bool saltar):base()
		{
			this.mov = mov;
			this.comidas = comidas;
			this.saltar = saltar;
		}

		void setMov(int newMov){
			mov = newMov;
		}int getMov(){
			return mov;
		}

		void setMov(int newMov){
			mov = newMov;
		}

		int getComidas(){
			return comidas;
		}

		void setComidas(int newComidas){
			comidas = newComidas;
		}

		bool isCaballo(){
			return saltar;
		}
	
		void setCaballo(bool newCaballo){
			saltar = newCaballo;
		}
	}
}

