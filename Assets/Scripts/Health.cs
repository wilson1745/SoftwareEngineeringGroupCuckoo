using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Health : MonoBehaviour
{
    // Current Health
    [SerializeField]
    int cur = 5;

    public void doDamage(int n)
    {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0)
            Destroy(gameObject);
    }

}