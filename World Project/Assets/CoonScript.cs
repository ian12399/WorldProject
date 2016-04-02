using UnityEngine;
using System.Collections;

public class CoonScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(transform.position.z < -5.5){

			if(Input.GetKey(KeyCode.Alpha1)){

				Vector3 pos = new Vector3(0,0, speed * Time.deltaTime);
				transform.position += pos;

			}
		}
		if(transform.position.z > -10){

			if(Input.GetKey(KeyCode.Alpha2)){

				Debug.Log("Nigger");
				Vector3 pos = new Vector3(0,0, -speed * Time.deltaTime);
				transform.position += pos;

		}

	}
}
}
