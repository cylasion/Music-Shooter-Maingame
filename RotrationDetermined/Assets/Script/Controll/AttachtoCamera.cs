using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachtoCamera : MonoBehaviour {

	 Controll CameraControll;
	 Transform CameraTraform;
	Camera camera;
	float x=0;
	float y=0;
	float L=0;
	float GocTrc=0;

	public float DolechnhoNhat=0; 	//Do lech cho phep goc thay doi, ho chinh trong ca control cua cameera

	public void cameraupdate(){
	/*	Vector3 position = CameraControll.getSpawerPosition ();
		Debug.Log (position);
		gameObject.transform.position = position;
	 */	float gocxoay = CameraControll.getAlpha () ;
		if(Mathf.Abs(gocxoay-GocTrc)>DolechnhoNhat){

			float mouseX = 0.5f;
			float mouseY = camera.pixelHeight / 2;
			Vector3 p = camera.ScreenToWorldPoint (new Vector3(mouseX,mouseY,camera.nearClipPlane+5));
			this.transform.position = p;
		/*	x = L * Mathf.Cos (gocxoay* Mathf.PI / 180);
			y = L * Mathf.Sin (gocxoay* Mathf.PI / 180);

			x = CameraTraform.position.x - x;
			y = CameraTraform.position.y + y;
			this.transform.position = new Vector3 (x,y,this.transform.position.z);*/

			GocTrc = gocxoay;
		}

	}


	void Awake () {
		L = Screen.height / 2 / 14;
		GameObject g =GameObject.Find ("Main Camera");
		CameraControll = g.GetComponent<Controll> ();
		CameraTraform = g.GetComponent<Transform> ();
		camera = g.GetComponent<Camera> ();
		cameraupdate ();

	}



	// Update is called once per frame
	void Update () {
		cameraupdate ();
	}

}
