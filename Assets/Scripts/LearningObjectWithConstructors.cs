using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningObjectWithConstructors : MonoBehaviour {

    public Person man;
    public Person woman;
	// Use this for initialization
	void Start () {

        man = new Person("Ali", "Adil");
        woman = new Person("XzyLrki", "Dont9ow");
        
        man.spouse = woman;
        woman.spouse = man;

        if (man.IsMarriedWith(woman))
        {
            Debug.Log(man.firstName + " is married to " + woman.firstName);
        }
        else
        {
            Debug.Log(man.firstName + " and " + woman.firstName + " are not married ");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
