using UnityEngine;
using System.Collections;

public class moveplayer : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		var speed = 1.0f;
		var movekey = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		transform.position += movekey * speed * Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Space)) {

			Instantiate (Resources.Load("kitten"), transform.position, Quaternion.identity);
		}
	
	}


}
