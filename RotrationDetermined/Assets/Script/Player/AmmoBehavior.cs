using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AmmoBehavior{
	protected Object Prefab;
	protected int Score;
	protected float Speed;
	protected Vector3 Direction;

	public void setDirection(Vector3 dir){
		Direction = dir;
	}
	public Vector3 getDirection(){
		return Direction;
	}
	public void setSpeed(float speed){
		Speed = speed;
	}

	public float getSpeed (){
		return Speed;
	}
	public void setScore(int s){
		Score = s;
	}
	public int getScore(){
		return Score;
	}

	public Object getPrefab(){
		return Prefab;
	}


		
}
