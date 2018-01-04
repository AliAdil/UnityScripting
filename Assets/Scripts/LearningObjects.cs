using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjects : MonoBehaviour {

	// Use this for initialization
    public Person man;
    public Person woman;
	void Start () {
        man = new Person();
        man.firstName = "Ali";
        man.lastName = "Adil";

        woman = new Person();
        woman.firstName = "SomeLarki";
        woman.lastName = "LastNameOfSomeLarki";

        man.spouse = woman;
        woman.spouse = man;
        if (man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + "is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName+ " and "+woman.firstName+" are not married ");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
