using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttacking : MonoBehaviour
{
    // Last Attack Time
    float last = 0;

    void OnCollisionStay2D(Collision2D coll)
    {
        // Collided with a item which is tagged as Plant?
        if (coll.gameObject.tag == "Plant")
        {
            // Deal damage once a second
            if (Time.time - last >= 1)
            {
                coll.gameObject.GetComponent<Health>().doDamage(1);
                last = Time.time;
            }
            //kill itself when reach tower
            callDeadAnimation();
        }

        // Collided with a BASE?
        if (coll.gameObject.tag == "HP")
        {
            // make hp-1
            coll.gameObject.GetComponent<BaseHealth>().doDamage(1);
			new WaitForSeconds(2);
			Destroy(gameObject);
        }
    }

    void callDeadAnimation()
    {
        AudioSource audio1 = GameObject.Find("Audio_Howl").GetComponent<AudioSource>();
        audio1.Play();
        Invoke("killitself", (float)0);
    }

    void killitself()
    {
        Destroy(gameObject);
    }

}