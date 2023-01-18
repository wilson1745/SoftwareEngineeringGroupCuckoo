using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCatAnimator : MonoBehaviour {

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
        AudioSource audio1 = GameObject.Find("Audio_fighting").GetComponent<AudioSource>();
        audio1.Play();
        GetComponent<Animator> ().Play ("catfight");
		GetComponent<Animator> ().CrossFade("catfight", 0.3f);

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
