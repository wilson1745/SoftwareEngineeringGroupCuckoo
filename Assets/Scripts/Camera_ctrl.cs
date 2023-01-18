using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Camera_ctrl : MonoBehaviour {

    public void EasyMODE()
    {
        SpawnEnemy.spawnPeriod = 15f;
        SceneManager.LoadScene("diadog_startLEVEL1");
    }

    public void NormalMODE()
    {
        SpawnEnemy.spawnPeriod = 10f;
        SceneManager.LoadScene("diadog_startLEVEL1");
    }

    public void DifficultMODE()
    {
        SpawnEnemy.spawnPeriod = 5f;
        SceneManager.LoadScene("diadog_startLEVEL1");
    }

    public void GoToSettingMODE()
    {
        SceneManager.LoadScene("chooseMODE");
    }

    public void ClickS()
    {
        level.difficulty = 1;
        Debug.Log("Start");
        SceneManager.LoadScene("diadog_startLEVEL1");
    }

    public void ClickAbout()
    {
        SceneManager.LoadScene("workers");
    }

    public void ClickTutorial()
    {
        level.difficulty = 0;
        SpawnEnemy.spawnPeriod = 5f;
        Debug.Log("Tutorial");
        SceneManager.LoadScene("GameMode0");
    }

    public void ClickToDog()
	{
		Debug.Log("Start");
        level.difficulty = 1;
        Dogmode.dogmode = true;
        SceneManager.LoadScene("Dogmodev1");
	}

    public void ClickBack()
    {
        Debug.Log("Back");
        SceneManager.LoadScene("GO");
    }

    public void ClickQ()
    {
        Debug.Log("Quit");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
