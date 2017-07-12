using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controll : MonoBehaviour {
	float basePhoneRotration =0;
	public float DoLechNhoNhat=0;
	//Do lech cho phep goc thay doi, ho chinh trong ca control cua spawer
	float lastRotration = 0;
	double Gocxoay;
	void Start () {
		
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
				Gocxoay = 180 - x / 0.0111;
			} else {
				Gocxoay = x / 0.0111;
			}
		} else {
			if (y <= 0) {
				Gocxoay = 360 + x / 0.0111;
			} else {
				Gocxoay = 180 - x / 0.0111;
			}
		}
		return (float) Gocxoay;
	}
	
	// Update is called once per frame
	void Update () {
		float gocxoay = getRotration();
		if(Mathf.Abs(gocxoay-lastRotration)>DoLechNhoNhat){
			this.transform.eulerAngles = new Vector3 (0,0,-gocxoay+basePhoneRotration);
		}
		lastRotration = gocxoay;
	}
	public float getAlpha(){
		return (float)Gocxoay;
	}
}
