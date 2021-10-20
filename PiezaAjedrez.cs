using System;

namespace helloWorld
{
	 public class PiezaAjedrez //TODO
	{

		string color; // comienza como Null 
		int posX;
		int posY;
		int mov;
		int comidas;
		 // posicion, color

		string getColor(){
			return color;
		}

		void setColor(string newColor){
			color= newColor; // this.
		}

		int getPosX(){
			return posX;
		}

		int getPosY(){
			return posY;
		}

		void setPosX(int newX){
			posX = newX;
		}
		void setPosY(int newY){
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

		void setComidas(int newComidas){
			comidas = newComidas;
		}

	}
}

