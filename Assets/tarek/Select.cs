using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {
	public GameObject a;
	public int sa;
	public GameObject canves;
	// Use this for initialization
	void Start () {
		//a=this.GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		
		Ahmed.AhmedInstance.Mesh=sa;
		// if (sa==Ahmed.AhmedInstance.Mesh)
		// {
		Ahmed.AhmedInstance.tex=null;
		Ahmed.AhmedInstance.hexcolor.r=255;
		Ahmed.AhmedInstance.hexcolor.g=255;
		Ahmed.AhmedInstance.hexcolor.b=255;
		Ahmed.AhmedInstance.hexcolor.a=0;
		// }
		
		//ColorButtons.ColorButtonsInstance
		
	}
	public void aa()
	{
		canves.SetActive(true);
	Ahmed.AhmedInstance.mesh=a;
	}
}
