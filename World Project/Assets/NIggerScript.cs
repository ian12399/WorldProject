using UnityEngine;
using System.Collections;

public class NIggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 rotation = new Vector3(horizontal * Time.deltaTime * 100, vertical * Time.deltaTime * 100, 0);
		transform.Rotate(rotation);

	}
}
