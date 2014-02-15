using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	void OnMouseDown () {
		Application.LoadLevel("GameScene");
	}
}
