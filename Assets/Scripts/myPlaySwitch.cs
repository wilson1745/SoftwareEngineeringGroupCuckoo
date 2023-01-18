using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class myPlaySwitch : MonoBehaviour
{
    public AudioSource _AudioSource;
    public AudioClip Audio_menu;
    public AudioClip Audio_gaming;

    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Debug.Log("Active scene is '" + currentScene.name + "'.");
        if (sceneName.Equals("GO"))
        {
            Debug.Log("menu music");
            _AudioSource.clip = Audio_menu;
            _AudioSource.Play();
        }
        else
        {
            Debug.Log("level1 music");
            _AudioSource.clip = Audio_gaming;
            _AudioSource.Play();
        }
        
    }
    
}