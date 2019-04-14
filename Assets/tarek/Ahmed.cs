using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ahmed : MonoBehaviour {
	public GameObject mesh;
	public int Mesh;
	public Renderer ren;
	public Material[] mat;
	public Texture tex;
	public Color hexcolor;
	
	private static Ahmed Ahmedinstance;
	public static Ahmed AhmedInstance 
	{
		get
		{
			return Ahmedinstance;
		}
	}
	
	// Use this for initialization
	void Start () {
		Ahmedinstance=this;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
 		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
		
        if (Physics.Raycast(ray, out hit, 1000))
		{
			Debug.DrawLine(ray.origin, hit.point);
			 if(hit.collider.isTrigger)
             {
                Debug.Log(1);
				hit.collider.gameObject.GetComponent<Select>().aa();
				ren = mesh.GetComponent<Renderer>();
				mat = ren.materials;
				mat[1].color =hexcolor;
				mat[1].mainTexture=tex;
             }	
		 }  
	}	
}
