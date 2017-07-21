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
	LineRenderer DirectionLine;
	Camera camera;
	void Start () {
		spawer = new Spawer1();
		ammo = new Ammo1();
		//Debug.Log (spawer.getPrefab());
		gun = Object.Instantiate (spawer.getPrefab(),transform,false);

		L = (Screen.height / 2) / 14;
		GameObject g = GameObject.Find ("Main Camera");
		CameraControll = g.GetComponent<Controll> ();
		CameraTraform = g.GetComponent<Transform> ();
		camera = g.GetComponent<Camera>();
		DirectionLine = GetComponent<LineRenderer> ();
	}
	public void ShootFromGun(){
		ammo.setDirection (AmmoDirection());
		Object.Instantiate (ammo.getPrefab (), Spawerposition(), transform.rotation);
	}


	void Update () {
	/*	float mouseX = 0.5f;
		float mouseY = camera.pixelHeight / 2;
		Vector3 p = camera.ScreenToWorldPoint (new Vector3(mouseX,mouseY,camera.nearClipPlane+5));
		DirectionLine.SetPosition (0,p);
		DirectionLine.SetPosition (1,new Vector3(CameraTraform.position.x,CameraTraform.position.y,CameraTraform.position.z+7));*/
	}


	public Vector3 Spawerposition(){
		float mouseX = 3f;
		float mouseY = camera.pixelHeight / 2;
		Vector3 p = camera.ScreenToWorldPoint (new Vector3(mouseX,mouseY,camera.nearClipPlane+5));
		return p;
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