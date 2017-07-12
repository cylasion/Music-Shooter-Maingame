using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawerBehavior  {
	protected Object Prefab;
	public Transform Root;
	protected AmmoBehavior ammo;


	public Object getPrefab(){
		return Prefab;
	}
	public void setAmmo(AmmoBehavior ammo){
		this.ammo = ammo;
	}

	public abstract Vector3 Shoot (Vector3 Target);
	//public abstract void setPrefab(Object prefab);

}
