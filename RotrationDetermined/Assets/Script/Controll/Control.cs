using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Control : MonoBehaviour {

    private float maxAngle = 180f; // goc lon nhat ma camera xoay dc
    public float duration = 0.75f; // thoi gian 1 lan xoay
	
	
	void Update () {

        transform.DORotateQuaternion(Quaternion.Euler(-Input.acceleration.x * maxAngle * Vector3.forward/2),
                                                duration);

	}
}
