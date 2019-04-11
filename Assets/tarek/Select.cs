using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {
	public GameObject a;
	//public GameObject canves;
	// Use this for initialization
	void Start () {
		//a.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		//canves.SetActive(true);
		Ahmed.SoundInstance.mesh=a;
	}
}
