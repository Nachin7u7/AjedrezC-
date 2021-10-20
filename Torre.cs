using System;

namespace helloWorld
{
	public class Torre:PiezaAjedrez
	{
		int mov;
		int comidas;
		bool enroque;

		public Torre (int mov, int comidas, bool enroque):base()
		{
			this.mov = mov;
			this.comidas = comidas;
			this.enroque = enroque;
		}

		int getMov(){
			return mov;
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

		bool isTorre(){
			return enroque;
		}

		void setTorre(int newTorre){
			enroque = newTorre;
		}

	}
}

