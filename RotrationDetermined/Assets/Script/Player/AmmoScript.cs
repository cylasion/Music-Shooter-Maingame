using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AmmoScript : MonoBehaviour {

	AmmoBehavior ammo;
	float Speed;
	float Score;
	Vector3 Direction;
	float time=0;
	//Rigidbody rigidbody;

	void Start () {
		GameObject gun = GameObject.Find("Gunner");
		ammo = gun.GetComponent<Gun> ().getAmmoInfo ();
		Speed = ammo.getSpeed ();
		Score = ammo.getScore ();
		Direction = ammo.getDirection ();
	//	rigidbody = GetComponent<Rigidbody> ();
		DOTween.Init ();
	}

	// Update is called once per frame
	void Update () {
		//rigidbody.DOMove (-Direction*50, 20 / Speed);
			time+=Time.deltaTime;
			transform.DOMove (Direction * 50, 20 / Speed);
			Destroy (this.gameObject, 2);
		}
	}

