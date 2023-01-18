using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {
    public BuildInfo dog;
    public static BuildInfo cur;
    public GameObject bulletPrefab;

    void clicktest1() {
        QActrl.answer_counter = 1 ;
        Debug.Log("1");
    }
    void clicktest2()
    {
        QActrl.answer_counter = 2;
        Debug.Log("2");
    }
    void clicktest3()
    {
        QActrl.answer_counter = 3;
        Debug.Log("3");
    }

    public void CreateTower()
    {
        if (level.score >= 3)
        {
            AudioSource audio1 = GameObject.Find("Audio_meow").GetComponent<AudioSource>();
            audio1.Play();
            for (int i=0;i<3;i++)
            {
                Instantiate(bulletPrefab, new Vector3(2, i+0.5f, 65), Quaternion.identity);
            }
            level.score -= 3;
        }
    }
    

    public void NormalSpeed()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
    
    public void BackToWelcome()
    {
        NormalSpeed();
        SceneManager.LoadScene("GO");
    }

    public void GotoStage1()
    {
        level.difficulty = 1;
        SceneManager.LoadScene("GameMode1");
    }

    public void GotoStage2()
    {
        level.difficulty = 2;
        if(Dogmode.dogmode == false){
            SceneManager.LoadScene("GameMode1");
        }else{
            SceneManager.LoadScene("Dogmodev1");
        }
    }
}
        
            
    
