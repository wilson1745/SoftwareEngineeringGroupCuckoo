using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showMessage : MonoBehaviour
{
    public Text NPCspeak;
    public static string whatNPCwhattosay = "";
    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        NPCspeak.text = whatNPCwhattosay;
    }
}