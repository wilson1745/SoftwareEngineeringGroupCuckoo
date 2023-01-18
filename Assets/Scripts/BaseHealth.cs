using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseHealth : MonoBehaviour
{
    public void doDamage(int n)
    {
        level.base_hp -= n;
    }
}