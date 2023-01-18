using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_damage : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D co)
    {
        // Zombie?
        if (co.tag == "Zombie")
        {

            // Deal Damage, destroy Bullet
            co.GetComponent<Health>().doDamage(500);
            Destroy(gameObject);

            AudioSource audio1 = GameObject.Find("Audio_Howl").GetComponent<AudioSource>();
            audio1.Play();
        }
    }
}