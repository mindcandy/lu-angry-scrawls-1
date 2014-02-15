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
			// find where mouse hits the world
			Vector3 hitPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			
			// get relative direction
			Vector2 target = hitPoint - transform.position;
			
			// rotate launcher to point at target
			float angle = Vector2.Angle(Vector2.right, target);
			if (target.y < 0.0f) angle = -angle;
			transform.eulerAngles = new Vector3(0.0f, 0.0f, angle);			

			// launch?
			if (Input.GetMouseButtonDown(0)) {
				Vector2 launchForce = transform.right * strength;
				player.AddForce(launchForce);
				player.AddTorque(twist);
				launched = true;
			}			
		} 
	}
}
