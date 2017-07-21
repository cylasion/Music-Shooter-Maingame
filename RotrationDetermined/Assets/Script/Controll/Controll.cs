using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Controll : MonoBehaviour {
	float basePhoneRotration =0;
	public float DoLechNhoNhat=0;
	public float TimeUpdate=0.05f;
	//Do lech cho phep goc thay doi, ho chinh trong ca control cua spawer
	float lastRotration = 0;
	double Gocxoay;
	Camera _camera;
	float time;
	void Start () {
		DOTween.Init ();
		_camera = GetComponent<Camera> ();
	}

	float getRotration(){
	float x =Input.acceleration.x;
		float y =Input.acceleration.y;
		x = (int)(x * 1000);
		y = (int)(y * 1000);
		x = x / 1000;
		y = y / 1000;
	
		 Gocxoay=0;
		if (x >= 0) {
			if (y > 0) {
				Gocxoay = 180 - x / 0.011111;
			} else {
				Gocxoay = x / 0.011111;
			}
		} else {
			if (y <= 0) {
				Gocxoay = 360 + x / 0.011111;
			} else {
				Gocxoay = 180 - x / 0.011111;
			}
		}
		return (float) Gocxoay;
	}
	
	// Update is called once per frame
	void Update () {
		if(time > TimeUpdate){
			float gocxoay = getRotration();
			if(Mathf.Abs(gocxoay-lastRotration)>DoLechNhoNhat){
				//gameObject.transform.DORotate ( new Vector3 (0,0,-gocxoay+basePhoneRotration),TimeUpdate,0);
				gameObject.transform.eulerAngles = new Vector3 (0,0,-gocxoay+basePhoneRotration);;
			}
			lastRotration = gocxoay;
			time = 0;
		}
		time += Time.deltaTime;

	}
	public float getAlpha(){
		return (float)Gocxoay;
	}

	public Vector3 getSpawerPosition(){
		Debug.Log (_camera.ViewportToWorldPoint(new Vector3(0,0.5f,_camera.nearClipPlane))+ "in controll scrpit");
		return _camera.ViewportToWorldPoint(new Vector3(0,0.5f,_camera.nearClipPlane));
	}
}
