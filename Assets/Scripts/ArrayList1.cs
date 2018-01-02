using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class ArrayList1 : MonoBehaviour {
  
    // Array declaration
    //public string[] arrayString = new string[] { };
    // List declaration
    //public List<string> listString = new List<string> { };
    
    //Array List declartation
    public ArrayList inventory = new ArrayList();
	// Use this for initialization
	void Start () {
        inventory.Add(10);
        inventory.Add(20);
        inventory.Add("Ali Adil");
        inventory.Add(GameObject.Find("Player"));

        Debug.Log(inventory[1].GetType());
        Debug.Log(inventory[2].GetType());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
