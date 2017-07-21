using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public Gun gun;

	
	public void shot(){
		gun.ShootFromGun ();
	}
}
