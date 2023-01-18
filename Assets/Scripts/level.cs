using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public Text Timer_textttt;
    public Text Bullet_textttt;
    public static int base_hp, score, times;
    public static int base_original_hp = 3;
    public static int difficulty = 1;
    int when_next_stage = 60;

    void Start()
    {
        InitDATA();
    }

    void InitDATA()
    {
        base_hp = base_original_hp;
        score = 0;
        times = 0;
    }

    void Update()
    {
        if (difficulty == 0) {
            base_hp = base_original_hp;
            if ((times % 10) <= 3)
            {
                tutorialTIPS(true);
            }
            else {
                tutorialTIPS(false);
            }
        }

        if (base_hp <= 0)
        {
            Invoke("YouLose", 1);
        }

        Timer_textttt.text = "" + times;
        Bullet_textttt.text = "x" + score;
        if(times>= when_next_stage)
        {
            if (difficulty == 1) {
                SceneManager.LoadScene("diadog_startLEVEL2");
            }
            else if (difficulty == 2) {
                SceneManager.LoadScene("dialog_win");
            }
        }
            
    }

    void YouLose() {
        difficulty = 1;
        SceneManager.LoadScene("dialog_loose");
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void BackToMenu() {
        Debug.Log("Back");
        SceneManager.LoadScene("GO");
    }

    void tutorialTIPS(bool a) {
        for (int i = 1; i <= 5; i++)
        {
            string str = "arrow" + i;
            string str1 = "HINT" + i;
            GameObject temp1 = GameObject.Find(str);
            GameObject temp2 = GameObject.Find(str);

            if(temp1 != null && temp2 != null){
                SpriteRenderer temprender = temp1.GetComponent<SpriteRenderer>();
                Text temptext = temp2.GetComponent<Text>();

                if(temprender != null && temptext != null){
                    temprender.enabled = a;
                    temptext.enabled = a;
                }
            }
           
        }
    }

   
}
