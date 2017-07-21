using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Randomtarget : MonoBehaviour {

	Camera cam;
	float time;
	public float CDtime = 2;
	public GameObject Prefab;

	void Start () {
		GameObject g =GameObject.Find ("Main Camera");
		cam = g.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(time > CDtime){
			Random rnd = new Random();
			float x = Random.Range (-9, 9);
			float y = Random.Range (-4,4);
			Vector3 p = new Vector3 (x,y,7);
			GameObject k =GameObject.Instantiate (Prefab, p, transform.rotation);
			Destroy (k,3);
			time = 0;
		}
		time = time + Time.deltaTime;
	}
}
