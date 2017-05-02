using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
//FINAL
public class ScriptingFinal : MonoBehaviour {
	public int math1 = 10;
	public int math2 = 2; 
	private int countingup = 0;
	public string integers;
	public List <string> Numbers = new List <string> ();
	// Use this for initialization
	//Function to print average number of items in a list of integers---LISTS
	void Integ () {
		Numbers.Add (" One ");
		Numbers.Add (" Two ");
		Numbers.Add (" Three ");
		Numbers.Add (" Four ");
		Numbers.Add (" Five ");
	}




	public void Start () {
		/*printing "Hello", my name , the surrent time
		*I can't figure out how to get it to print out the time. . . It's printing out something, but not what I want it to  . . .*/
		
		print (" Hello, my name is " + " Laurie " + " the current time is " + Time.maximumDeltaTime);
		}
		


	/*creating an add, subtract, multiply, divide function that will work when their corresponding buttons in Unity are pushed
	 * I also created the variables as PUBLIC so that you can change the numbers in unity to run whatever numbers in whichever 
	 * functions you want */

	public void addition () {
		

			float add = (math1 + math2);
			print (" The total sum is " + add);

	}
	public void subtraction () {
		
			
		float subtract = (math1 - math2 );
		print ( " the total is " + subtract );

	}
	public void multiplication () {
		
			
		float   multiply  = (math1 * math2 );
		print ( " The answer is " + multiply );

	}

	public void division () {
		

		float  divide = (math1 / math2 );
		print (" The end result is " + divide );

	}

}
