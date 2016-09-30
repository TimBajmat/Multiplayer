using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Movement : NetworkBehaviour {

	public float speed = 30;    
	public string axis = "Vertical";

	void FixedUpdate()
	{
		if(!isLocalPlayer)
		{
			return;
		}
			
		float v = Input.GetAxisRaw(axis);
		GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
	}
		
}
