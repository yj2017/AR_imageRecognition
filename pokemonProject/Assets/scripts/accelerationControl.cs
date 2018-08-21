using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerationControl : MonoBehaviour {

	float speed =200;
	//static bool isTouched=false;
	// Use this for initialization
	void Start () {
		
		//isTouched=false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount >=1){
			isTouched=true;
		}
		//点击屏幕次数超过1
		//if (isTouched){
			//根据重力加速度来移动游戏对象
		Vector3 mMovement=new Vector3(Input.acceleration.x*speed*Time.deltaTime,Input.acceleration.y*speed*Time.deltaTime);
		transform.Translate(mMovement);
		//}


	}
}
