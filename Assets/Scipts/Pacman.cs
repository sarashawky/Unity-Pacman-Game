using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour {

	public float speed;
	private Rigidbody rbody;

	// Use this for initialization
	void Start () 
	{
		speed= 150f;
		rbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update ()
	{
		//transform.Translate (speed*Input.GetAxis ("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis ("Vertical")*Time.deltaTime);
		rbody.AddForce (speed*Input.GetAxis ("Horizontal")*Time.deltaTime,0f,speed*Input.GetAxis ("Vertical")*Time.deltaTime);
	}
	void  OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("food"))
			{
				other.gameObject.SetActive(false);
				
			}
			
	}


}
