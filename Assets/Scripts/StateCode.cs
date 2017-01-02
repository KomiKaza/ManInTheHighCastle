using UnityEngine;
using System.Collections;

public class StateCode : MonoBehaviour {

	public string name;
	public double republican;
	public double democrate;
	public double floaters;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Color c = (floaters > (republican) && floaters > democrate) ? Color.white : (republican > democrate ? Color.red : Color.blue);
	
			GetComponent<SpriteRenderer> ().color = c;


	}
}
