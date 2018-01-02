using UnityEngine;
using System.Collections;

public class ArrayList : MonoBehaviour {
	public string[] members = new string[] {"ALi","Adil","Usman","Bilal"};
	// Use this for initialization


	void Start () {
		Debug.Log (members [1]+" "+members[0]);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
