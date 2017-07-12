using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawer1 : SpawerBehavior {

	public Spawer1(){
		Prefab = (GameObject)Resources.Load ("Spawer1");
	}

	public override Vector3 Shoot (Vector3 Target){
		return Target - Root.position;
	}

}
