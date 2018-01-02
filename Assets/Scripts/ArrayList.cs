using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayList : MonoBehaviour {
    //array declaration
    //public string[] membersArray = new string[] {"ali","adil","usman","bilal"};
    
    //list declaration
    public List<string> membersList = new List<string>();

	void Start () {
        // for array 
		//Debug.Log (membersArray [1]+" "+membersArray[0]);
        membersList.Add("ALi");
        membersList.Add("Usman");
        membersList.Add("Bilal");
        membersList.Add("Adil");
        foreach (var item in membersList)
        {
            Debug.Log(item);
        }
        string thirdMemberInList = membersList[2];
        Debug.Log("Third member of list is "+thirdMemberInList);
	}
	
	// Update is called once per frame
    //void Update () {
	
    //}
}
