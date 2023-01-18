using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogmode : MonoBehaviour {

    public static bool dogmode = false;

	// Use this for initialization
	void Start () {
        dogmode = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetDogModeFalse(){
        dogmode = false;
    }


}
