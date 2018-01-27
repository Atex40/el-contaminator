using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_Contamination : MonoBehaviour {

	public float rayLenght;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 myray = Camera.main.transform.forward;
		RaycastHit hit;
		Debug.DrawRay(transform.position, myray * 20, Color.green);

		if (Physics.Raycast(Camera.main.transform.position, myray, out hit, rayLenght))
		{
			if(hit.collider.gameObject.CompareTag ("CUBASS"))
			{
				Debug.Log (hit.collider.name);

				if (Input.GetKeyDown("e"))
				{
					hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
					hit.collider.gameObject.transform.tag = "mort";
				}
			}
		}		
	}
}
