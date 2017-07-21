using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo1 : AmmoBehavior {
	public Ammo1(){
		Prefab = (Object)Resources.Load ("Ammo1");
		Speed = (float) 0.5f;
		Score = 10;
	}

}
