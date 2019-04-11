using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahmed : MonoBehaviour {
	public GameObject mesh;
	public Renderer ren;
	public Material[] mat;
	public Texture tex;
	public Color hexcolor;
	public float r;
	private static Ahmed Soundinstance;
	public static Ahmed SoundInstance 
	{
		get
		{
			return Soundinstance;
		}
	}
	
	// Use this for initialization
	void Start () {
		Soundinstance=this;
	}
	
	// Update is called once per frame
	void Update () {
		
 		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
		
        if (Physics.Raycast(ray, out hit, 1000))
		{
			Debug.DrawLine(ray.origin, hit.point);
			ren = mesh.GetComponent<Renderer>();
			mat = ren.materials;
			//r=hexcolor.r;
			//mat[1].color =Color.red;
			mat[1].mainTexture=tex;
			
		}
            
        
	}	
}
