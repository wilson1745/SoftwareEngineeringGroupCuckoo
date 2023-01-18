using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
    public GameObject hole;
    void OnMouseUpAsButton()
    {
        if (level.score > 0)
        {
            Instantiate(hole.gameObject, transform.position, Quaternion.identity);
            level.score--;
        }
    }
}