using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_fire : MonoBehaviour {
    public GameObject bullet;
    void OnMouseUpAsButton()
    {
        if (level.score > 0) {
            AudioSource audio1 = GameObject.Find("Audio_meow").GetComponent<AudioSource>();
            audio1.Play();
            Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
            level.score--;
        }
          
    }
}

