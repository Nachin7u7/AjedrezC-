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

		int getMovimiento(){
			return movimiento;
		}
		void setMovimiento(int newMov){
			movimiento = newMov;
		}

		int getComidas(){
			return comidas;
		}
		void setComidas(int newCom){
			comidas = newCom;
		}

		bool isPeon(){
			return isPeon;
		}

		void setPeon(bool newPeon){
			peon = newPeon;
		}
	}
}

