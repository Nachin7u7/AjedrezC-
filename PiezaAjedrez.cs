using System;

namespace helloWorld
{
	public abstract class PiezaAjedrez //TODO
	{

		public string color; // comienza como Null 
		public int posX;
		public int posY;
		public int mov;
		public string name;
		public int comidas;
		 // posicion, color

		//public PiezaAjedrez(int mov, int comidas, int posX, int poxY, string color);

		string getColor(){
			return color;
		}

		void setColor(string newColor){
			color= newColor; // this.
		}

		public int getPosX(){
			return posX;
		}

		public int getPosY(){
			return posY;
		}

		public void setPosX(int newX){
			posX = newX;
		}
		public void setPosY(int newY){
			posY = newY;
		}

		void setMov(int newMov){
			mov = newMov;
		}

		int getMov(){
			return mov;
		}

		int getComidas(){
			return comidas;
		}

		public string getName(){
			return name;
		}
		public void setName(string newName){
			name = newName;
		}

		void setComidas(int newComidas){
			comidas = newComidas;
		}

	}
}

