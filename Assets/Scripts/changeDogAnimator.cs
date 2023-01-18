using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeDogAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Last Attack Time
	float last = 0;
	bool flag = false;

	void OnCollisionStay2D(Collision2D coll)
	{
		GetComponent<Animator> ().Play ("catfight1");
		GetComponent<Animator> ().CrossFade("catfight1", 2.0f);

	}



//	void callDeadAnimation()
//	{
//		GetComponent<Animator>().SetTrigger("IsDead");
//		gameObject.GetComponent<DefaultVelocity>().velocity.x = 0;
//		Invoke("killitself", (float)1);
//	}
//
//	void killitself()
//	{
//		Destroy(gameObject);
//	}
}
