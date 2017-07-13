using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
	Animator animate;
	Vector3 gone ;
	float time =0;
	void Start () {
		this.enabled = true;
		animate = GetComponent<Animator> ();
		float x= transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		 gone = new Vector3 (x+100,y+100,z);

	}
	
	void Update () {
		time += Time.deltaTime;
		animate.Play ("Target");

	}
	public void AnimationStartEvent(){
		time = 0;
	}

	public void EndAnimationEvent(){
		gameObject.SetActive(false);

		this.transform.position = gone; //Dich chuyen no ra cho khac, khi nao can thi dem lai chu o can phai tao 1 ban sao ms 
		Score.FailCombo ();
	}
	//Nho danh tag cho Ammo
	void OnTriggerEnter(Collider obj){
		if(obj.gameObject.tag == "Ammo"){
			gameObject.SetActive(false);

		/*	AmmoBehavior ammo = obj.gameObject;
			Score.Add (ammo.getScore(),time);
		*/
		}
	}
}
