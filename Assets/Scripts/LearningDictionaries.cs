using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningDictionaries : MonoBehaviour {

    public Hashtable personalDetails = new Hashtable();
	// Use this for initialization
	void Start () {
        personalDetails.Add("firstName", "Ali");
        personalDetails.Add("lastName", "Adil");
        personalDetails.Add("gender", "male");
        personalDetails.Add("isMarried", false);
        personalDetails.Add("age", 26);
        Debug.Log("My Age is "+(int)personalDetails["age"]);

        if (personalDetails.Contains("firstName"))
        {
            Debug.Log((string)personalDetails["firstName"]);
        }
        else
        {
            Debug.Log("Personal Detials isn't stored in hashtable");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
