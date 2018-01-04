using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjects : MonoBehaviour {
    
	// Use this for initialization
    public Person man;
    public Person woman;
    public Person totalage;
	void Start () {
        man = new Person();
        man.firstName = "Ali";
        man.lastName = "Adil";
        man.age = 26;


        woman = new Person();
        woman.firstName = "SomeLarki";
        woman.lastName = "LastNameOfSomeLarki";
        woman.age = 24;

        totalage = new Person();

        man.spouse = woman;
        woman.spouse = man;
        if (man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + " is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName+ " and "+woman.firstName+" are not married ");
        }

        Debug.Log("Both man and woman age is  " + totalage.BothPersonAgeTotal(man.age, woman.age)+" years");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
