using UnityEngine;
using System.Collections;

public class LearningStatements : MonoBehaviour {
	public bool willItBeRainingToday = true;
	// Use this for initialization
	void Start () {
	if (willItBeRainingToday) {
			Debug.Log ("Yes you need umbrella");
		} else {
			Debug.Log("No you don't need umbrella");
		}
	
	// Update is called once per frame
	
	}}
