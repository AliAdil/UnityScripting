using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour {

    public Person father;
    public Person mother;
    public Person son;

	// Use this for initialization
	void Start () {
        father = new Person();
        father.firstName = "Ali";
        father.lastName = "Adil";
        father.age = 26;
        father.isMale = true;
        father.isMarried = true;

        mother = new Person();
        mother.firstName = "Xyx";
        mother.lastName = "Sweet";
        mother.age = 24;
        mother.isMale = false;
        mother.isMarried = true;

        son = new Person();
        son.firstName = "Abc";
        son.lastName = "cba";
        son.age = 3;
        son.isMale = true;
        son.isMarried = false;


        Debug.Log(father.firstName + " and "+ mother.firstName+" have beautiful son "+son.firstName);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
