using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person  {

    public string firstName = "";
    public string lastName = "";
    public Person spouse;
    // below varibale are used in family class 
    public int age = 0;
    public bool isMale = false;
    public bool isMarried = false;

    public bool IsMarriedWith(Person otherPerson)
    {
        if (spouse != null)
        {
            // person object is stored in spouse variable 
            if (otherPerson == this.spouse)
            {
                //otherPerson object is the same as stored spouse
                return true;
            }
            else
            {
                //not married
                return false;
            }
        }
        else
        {
            return false;
        }
    }
	
}
