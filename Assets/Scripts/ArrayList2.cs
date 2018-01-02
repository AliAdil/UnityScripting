using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayList2 : MonoBehaviour
{
    //array declaration
    //public string[] membersArray = new string[] {"ali","adil","usman","bilal"};

    //list declaration
    public List<string> membersList = new List<string>();

    void Start()
    {
        // for array 
        //Debug.Log (membersArray [1]+" "+membersArray[0]);
        membersList.Add("ALi");
        membersList.Add("Usman");
        membersList.Add("Bilal");
        membersList.Add("Adil");

        int bilalIndex = -1;
        for (int i = 0; i <= membersList.Count; i++)
        {
            if (membersList[i] == "Bilal")
            {
                bilalIndex = i;
                break;
            }
        }
        if (bilalIndex == -1)
        {
            Debug.Log("Bilal value is not stored in the Member List");
        }
        else
        {
            Debug.Log("Bilal is found in the member list at index " + bilalIndex);
        }
        //    foreach (var item in membersList)
        //    {
        //        Debug.Log(item);
        //    }
        //    string thirdMemberInList = membersList[2];
        //    Debug.Log("Third member of list is " + thirdMemberInList);
        //}

        // Update is called once per frame
        //void Update () {

        //}
    }
}
