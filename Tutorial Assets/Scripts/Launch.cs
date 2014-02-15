using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {
	
	public Rigidbody2D player;
	
	public float strength = 200.0f;
	public float twist = 0.0f;

	bool launched;
	
	// Use this for initialization
	void Start () {
		launched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!launched) {
			// launch?
			if (Input.GetMouseButtonDown(0)) {
				Vector2 launchForce = new Vector2(0.5f, 0.5f) * strength;
				player.AddForce(launchForce);
				player.AddTorque(twist);
				launched = true;
			}
		} 
	}	
}
