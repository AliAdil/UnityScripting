using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsInStatements : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for (int i = 0; i <= 1000; i++)
        {
            if (i == 0)
            {
                Debug.Log(i + "number is Zero");
            }
            else if (IsEven(i))
            {
                Debug.Log(i + "is even");
            }
            else
            {
                Debug.Log(i + "is odd");
            }
        }
		
	}

    public bool IsEven(int numb)
    {
        if (numb % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
