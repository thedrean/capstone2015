using UnityEngine;
using System.Collections;
public class kitten : MonoBehaviour {
	public float speed = 6.0f;
	// Use this for initialization
	void Start () {
		Vector2 force = new Vector2(speed, 0.0f);
		Rigidbody2D vel = GetComponent<Rigidbody2D> ();
		vel.velocity = force;

	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnBecameInvisible() {
		Destroy(gameObject);
	}



}
