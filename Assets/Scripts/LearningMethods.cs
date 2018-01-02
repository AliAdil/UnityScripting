using UnityEngine;
using System.Collections;

public class LearningMethods : MonoBehaviour {
	void Awake(){
		Debug.Log ("Awake function is called");
		Debug.Log (Time.time);
	}
	// Use this for initialization
	void Start () {
	
		Debug.Log ("Start function is called"+Time.time);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update function is called"+Time.time);
	
	}
}
