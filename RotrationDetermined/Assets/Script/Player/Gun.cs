using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	SpawerBehavior spawer;
	AmmoBehavior ammo;
	Object gun;
	Controll CameraControll;
	Transform CameraTraform;
	float time = 0,L;

	void Start () {
		spawer = new Spawer1();
		ammo = new Ammo1();
		Debug.Log (spawer.getPrefab());
		gun = Object.Instantiate (spawer.getPrefab(),transform,false);

		L = (Screen.height / 2) / 14;
		GameObject g = GameObject.Find ("Main Camera");
		CameraControll = g.GetComponent<Controll> ();
		CameraTraform = g.GetComponent<Transform> ();

	}

	void FixedUpdate () {
		if(time > 3){
			time = 0;
			ammo.setDirection (AmmoDirection());
			Object.Instantiate (ammo.getPrefab (), transform.position, transform.rotation);
		}
		time += Time.deltaTime;
	}


	public Vector3 Spawerposition(){
		
		float gocxoay = CameraControll.getAlpha () * Mathf.PI / 180;

		float x = L * Mathf.Cos (gocxoay);
		float y = L * Mathf.Sin (gocxoay);

		x = CameraTraform.position.x - x;
		y = CameraTraform.position.y + y;
		return new  Vector3 (x,y,this.transform.position.z);
	}

	public Vector3 AmmoDirection(){
		Vector3 direc = -Spawerposition() + CameraTraform.position;
		direc.z = 0;
		return direc;
	}



	public AmmoBehavior getAmmoInfo(){
		return ammo;
	}
	// Update is called once per frame

}
/*The Orthographic camera size setting affects the area the camera covers. It's half of the screen height in units. So if your screen's vertical resolution is 1050, setting orthographic size to 525 would result in 1 pixel == 1 world unit. 800x600 sprite with a "pixels to units" setting of 1 would appear 800x600 on screen.

If for some reason (physics scale) you have to use a smaller camera size, you have to scale up "pixels to units" with the same ratio.*/