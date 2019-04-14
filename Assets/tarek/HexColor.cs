using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexColor : MonoBehaviour {
	public Color HexColorbutton;
	public Texture texter;
	private static HexColor HexColorinstance;
	public static HexColor HexColorInstance 
	{
		get
		{
			return HexColorinstance;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void colorbutton()
	{
		Ahmed.AhmedInstance.hexcolor=HexColorbutton;
	}
		public void Texterbutton()
	{
		Ahmed.AhmedInstance.tex=texter;
	}

}
	
