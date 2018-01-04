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

    public Person()
    {

    }

    public Person(string pFirstName, string pLastName)
    {
        this.firstName = pFirstName;
        this.lastName = pLastName;
    }

    public int BothPersonAgeTotal (int age1 , int age2)
    {

            int total = age1+age2;
            return total;
    }

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
