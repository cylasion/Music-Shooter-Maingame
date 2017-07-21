using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Controll : MonoBehaviour {
	float basePhoneRotration =0;
	public float DoLechNhoNhat=0;
	public float TimeUpdate=0.05f;
	public float duration = 0.15f;
	//Do lech cho phep goc thay doi, ho chinh trong ca control cua spawer
	float lastRotration = 0;
	double Gocxoay;
	Camera _camera;
	float time;
	void Start () {
		DOTween.Init ();
		_camera = GetComponent<Camera> ();
	}


	void Update () {

		gameObject.transform.DORotateQuaternion(Quaternion.Euler(-Input.acceleration.x * 180 * Vector3.forward/2),
			duration);
		
	}


	public Vector3 getSpawerPosition(){
		return _camera.ViewportToWorldPoint(new Vector3(0,0.5f,_camera.nearClipPlane));
	}
}
