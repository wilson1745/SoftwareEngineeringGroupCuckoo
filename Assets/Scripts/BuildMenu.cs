using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour
{
    // Sun Image
    public Texture sunImage;

    // Plant Prefabs
    public BuildInfo[] plants;

    // Currently building...
    public static BuildInfo cur;


    void OnGUI()
    {
        // Begin Gui
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, -7, 350, 100));
        GUILayout.BeginHorizontal("box");

        // Draw the Sun
        GUILayout.Box(new GUIContent(SunCollect.score.ToString(), sunImage));

        // Draw each Plant's BuildInfo
        foreach (BuildInfo bi in plants)
        {
            //GUI.enabled = SunCollect.score >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
            {
                if (SunCollect.score >= bi.price)
                {
                    cur = bi;
                }
            }
        }

        if (GUILayout.Button(new GUIContent("1x speed")))
        {
            Time.timeScale = 1;
        }
        if (GUILayout.Button(new GUIContent("0x speed")))
        {
            Time.timeScale = 0;
        }
        if (GUILayout.Button(new GUIContent("Quit")))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit();
        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }

   
}
