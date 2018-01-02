using UnityEngine;
using System.Collections;

public class LearningScript : MonoBehaviour {

	// Use this for initialization
	public int numb1= 5;
	public int numb2= 6;
	public int numb3= 7;
  	
	void Start () {
		int result = AddAndPrintTwoNumbers (numb1 ,numb2);
		GrandTotal (result);
	}
	
	// Update is called once per frame
	int AddAndPrintTwoNumbers(int number1 , int number2){
		int result = number1 + number2;
		return result;
	}

	void GrandTotal(int total){
		Debug.Log ("The grand total is " + total);}
}
