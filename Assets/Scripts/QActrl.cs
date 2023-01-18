using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QActrl : MonoBehaviour {
    static int totalQnum = 21;
    static string[] Questions = new string[totalQnum];
    static string[] OptionA = new string[totalQnum];
    static string[] OptionB = new string[totalQnum];
    static string[] OptionC = new string[totalQnum];
    static int[] Answers = new int[totalQnum];

    public Transform button1, button2, button3;

    public Text QQQ;
    public int question_counter = 0;
    public int pre_question_counter = -1;
    public static int answer_counter = 0;

    // Use this for initialization
    void Start () {
        SetQ();
        setAns();
        correctAnswer();
        HideSpeak();
        pre_question_counter = -1;
        autoQcnt();
    }

    void Update() {
        PrintQuestions(Questions);
    }

    void SetQ()
    {
        if (level.difficulty == 0) {
            for (int i = 0; i < totalQnum; i++) {
                string str = " 1+1 = 2 ? ";
                Questions[i] = str;
            }
        }
        else if (level.difficulty == 1) { 
            Questions[0] = "Given 0001 in base-2, what’s the equal number in base-10?";
            Questions[1] = "Given 0010 in base-2, what’s the equal number in base-10?";
            Questions[2] = "Given 0100 in base-2, what’s the equal number in base-10?";
            Questions[3] = "Given 1000 in base-2, what’s the equal number in base-10?";
            Questions[4] = "Given 0011 in base-2, what’s the equal number in base-10?";
            Questions[5] = "Given 1100 in base-2, what’s the equal number in base-10?";
            Questions[6] = "Given 0110 in base-2, what’s the equal number in base-10?";
            Questions[7] = "Given 1001 in base-2, what’s the equal number in base-10?";
            Questions[8] = "Given 1010 in base-2, what’s the equal number in base-10?";
            Questions[9] = "Given 0111 in base-2, what’s the equal number in base-10?";
            Questions[10] = "Given 1111 in base-2, what’s the equal number in base-10?";

            Questions[11] = "Given 0000 0001 in base-2, what’s the equal number in base-16?";
            Questions[12] = "Given 0000 1111 in base-2, what’s the equal number in base-16?";
            Questions[13] = "Given 0001 0000 in base-2, what’s the equal number in base-16?";
            Questions[14] = "Given 0001 0001 in base-2, what’s the equal number in base-16?";
            Questions[15] = "Given 0001 0010 in base-2, what’s the equal number in base-16?";
            Questions[16] = "Given 0001 1000 in base-2, what’s the equal number in base-16?";
            Questions[17] = "Given 0100 0001 in base-2, what’s the equal number in base-16?";
            Questions[18] = "Given 0010 1000 in base-2, what’s the equal number in base-16?";
            Questions[19] = "Given 1000 1111 in base-2, what’s the equal number in base-16?";

            Questions[20] = "To understand what recursion is, you must first understand ___";
        }
        else if (level.difficulty == 2)
        {
            Questions[0] = "Which of the following is not a valid C variable name ?";
            Questions[1] = "Which of the following is not a valid variable name declaration ?";
            Questions[2] = "What is the size of an int data type ?";
            Questions[3] = "How to make a comment ?";
            Questions[4] = "What the 5 % 2 answer is ?";
            Questions[5] = "Which one is not doing add ?";
            Questions[6] = "Which one is *or*";
            Questions[7] = "Which one is *and*";
            Questions[8] = "How to store 2 integers ?";
            Questions[9] = "Which is correct with respect to size of the datatypes ?";
            Questions[10] = "In C language, how to print something on the screen?";
            Questions[11] = "In C language, how to read something from the programmer?";
            Questions[12] = "In C language, do we need an function called ** main() ** ?";
            Questions[13] = "Which header file includes a function for variable number of arguments?";
            Questions[14] = "The standard header _______ is used for variable list arguments (...) in C.";
            Questions[15] = "Which of the following function can be used to terminate the main function from another function safely?";
            Questions[16] = "If we need to make 'a->A', which one should we use?";
            Questions[17] = "If we need to make 'A->a', which one should we use?";
            Questions[18] = "Which one should we use if we want to check something is a number or not?";
            Questions[19] = "Which one should we use if we want to check something is a control character or not?";

            Questions[20] = "Two bytes meet. The first byte asks, “Are you ill?” The second byte replies, “No, just feeling ___.”";
        }
    }

    void setAns() {
        if (level.difficulty == 0)
        {
            for (int i = 0; i < totalQnum; i++)
            {
                OptionA[i] = "Yes";
                OptionB[i] = "No";
                OptionC[i] = "Don't know";
            }
        }
        else if (level.difficulty == 1)
        {
            OptionA[0] = "1"; OptionB[0] = "2"; OptionC[0] = "3";//1
            OptionA[1] = "3"; OptionB[1] = "2"; OptionC[1] = "1";//2
            OptionA[2] = "4"; OptionB[2] = "5"; OptionC[2] = "6";//4
            OptionA[3] = "7"; OptionB[3] = "8"; OptionC[3] = "9";//8
            OptionA[4] = "1"; OptionB[4] = "2"; OptionC[4] = "3";//3
            OptionA[5] = "10"; OptionB[5] = "11"; OptionC[5] = "12";//12
            OptionA[6] = "5"; OptionB[6] = "6"; OptionC[6] = "7";//6
            OptionA[7] = "9"; OptionB[7] = "10"; OptionC[7] = "11";//9
            OptionA[8] = "9"; OptionB[8] = "10"; OptionC[8] = "11";//10
            OptionA[9] = "7"; OptionB[9] = "8"; OptionC[9] = "9";//7
            OptionA[10] = "14"; OptionB[10] = "15"; OptionC[10] = "16";//15

            OptionA[11] = "0x00"; OptionB[11] = "0x01"; OptionC[11] = "0x02";//0x01
            OptionA[12] = "0x0F"; OptionB[12] = "0x0E"; OptionC[12] = "0x0D";//0x0F
            OptionA[13] = "0x09"; OptionB[13] = "0x10"; OptionC[13] = "0x11";//0x10
            OptionA[14] = "0x11"; OptionB[14] = "0x21"; OptionC[14] = "0x31";//0x11
            OptionA[15] = "0x11"; OptionB[15] = "0x12"; OptionC[15] = "0x13";//0x12
            OptionA[16] = "0x08"; OptionB[16] = "0x18"; OptionC[16] = "0x28";//0x18
            OptionA[17] = "0x41"; OptionB[17] = "0x40"; OptionC[17] = "0x39";//0x41
            OptionA[18] = "0x26"; OptionB[18] = "0x27"; OptionC[18] = "0x28";//0x28
            OptionA[19] = "0x8F"; OptionB[19] = "0x8E"; OptionC[19] = "0x7F";//0x8F

            OptionA[20] = "recursion"; OptionB[20] = "excursion"; OptionC[20] = "incursion";//recursion
        }
        else if (level.difficulty == 2)
        {
            OptionA[0] = "int num"; OptionB[0] = "float rate"; OptionC[0] = "int $main";//c
            OptionA[1] = "_a3"; OptionB[1] = "a_3"; OptionC[1] = "3_a";//c
            OptionA[2] = "Depends"; OptionB[2] = "8 Bytes"; OptionC[2] = "4 Bytes";//a
            OptionA[3] = "--"; OptionB[3] = "//"; OptionC[3] = "%";//b
            OptionA[4] = "0"; OptionB[4] = "1"; OptionC[4] = "2";//b
            OptionA[5] = "a++"; OptionB[5] = "++a"; OptionC[5] = "a//++";//c
            OptionA[6] = "&&"; OptionB[6] = "||"; OptionC[6] = "&";//b
            OptionA[7] = "%%"; OptionB[7] = "&&"; OptionC[7] = "||";//b
            OptionA[8] = "int a[2]"; OptionB[8] = "int a"; OptionC[8] = "double a";//a
            OptionA[9] = "char > int"; OptionB[9] = "char > float"; OptionC[9] = "int < double";//c

            OptionA[10] = "getf"; OptionB[10] = "printf"; OptionC[10] = "scanf";//b
            OptionA[11] = "scanf"; OptionB[11] = "getf"; OptionC[11] = "printf";//a
            OptionA[12] = "yes"; OptionB[12] = "no"; OptionC[12] = "dont know";//a
            OptionA[13] = "stdlib.h"; OptionB[13] = "stdarg.h"; OptionC[13] = "ctype.h";//b
            OptionA[14] = "stdio.h"; OptionB[14] = "math.h"; OptionC[14] = "stdarg.h";//c
            OptionA[15] = "return(expr)"; OptionB[15] = "exit(expr)"; OptionC[15] = "abort()";//b
            OptionA[16] = "iscntrl()"; OptionB[16] = "tolower()"; OptionC[16] = "toupper()";//c
            OptionA[17] = "tolower()"; OptionB[17] = "toupper()"; OptionC[17] = "isalpha()";//a
            OptionA[18] = "isdigit()"; OptionB[18] = "iscntrl()"; OptionC[18] = "isalpha()";//a
            OptionA[19] = "isalpha()"; OptionB[19] = "isdigit()"; OptionC[19] = "iscntrl()";//c

            OptionA[20] = "dizzy"; OptionB[20] = "a bit off"; OptionC[20] = "overwhelmed ";//a bit off
        }
    }

    void correctAnswer() {
        if (level.difficulty == 0)
        {
            for (int i = 0; i < totalQnum; i++)
            {
                Answers[i] = 1;
            }
        }
        else if (level.difficulty == 1)
        {
            Answers[0] = 1;
            Answers[1] = 2;
            Answers[2] = 1;
            Answers[3] = 2;
            Answers[4] = 3;
            Answers[5] = 3;
            Answers[6] = 2;
            Answers[7] = 1;
            Answers[8] = 2;
            Answers[9] = 1;

            Answers[10] = 2;
            Answers[11] = 2;
            Answers[12] = 1;
            Answers[13] = 2;
            Answers[14] = 1;
            Answers[15] = 2;
            Answers[16] = 2;
            Answers[17] = 1;
            Answers[18] = 3;
            Answers[19] = 1;

            Answers[20] = 1;
        }
        else if (level.difficulty == 2)
        {
            Answers[0] = 3;
            Answers[1] = 3;
            Answers[2] = 1;
            Answers[3] = 2;
            Answers[4] = 2;
            Answers[5] = 3;
            Answers[6] = 2;
            Answers[7] = 2;
            Answers[8] = 1;
            Answers[9] = 3;

            Answers[10] = 2;
            Answers[11] = 1;
            Answers[12] = 1;
            Answers[13] = 2;
            Answers[14] = 3;
            Answers[15] = 2;
            Answers[16] = 3;
            Answers[17] = 1;
            Answers[18] = 1;
            Answers[19] = 3;

            Answers[20] = 2;
        }
    }
    

    void IncreaseScore() {
        level.score+=1;
    }

    void PrintQuestions(string[] Q) {
        QQQ.text = "Q : " + Q[question_counter];
        GameObject.Find("Ans1").GetComponentInChildren<Text>().text = OptionA[question_counter];
        GameObject.Find("Ans2").GetComponentInChildren<Text>().text = OptionB[question_counter];
        GameObject.Find("Ans3").GetComponentInChildren<Text>().text = OptionC[question_counter];

        if (answer_counter != 0) {
            if (answer_counter == Answers[question_counter])
            {
                Debug.Log("WINNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN");
                IncreaseScore();

                AudioSource audio1 = GameObject.Find("Audio_success").GetComponent<AudioSource>();
                audio1.Play();
               
                SpriteRenderer sprender = GameObject.Find("correct_Ans").GetComponent<SpriteRenderer>();
                sprender.enabled = true;

                Invoke("HideSpeak", 1);
                enableButtonslater(1);
                autoQcnt();
                answer_counter = 0;
            }
            else if (answer_counter > 0 && answer_counter <= 3)
            {
                CameraShake.Shake(0.5f, 0.05f);

                SpriteRenderer sprender = GameObject.Find("wrong_Ans").GetComponent<SpriteRenderer>();
                sprender.enabled = true;

                AudioSource audio2 = GameObject.Find("Audio_fail").GetComponent<AudioSource>();
                audio2.Play();

                Invoke("HideSpeak", 1);
                answer_counter = 0;
                enableButtonslater(1);
            }
        }
    }

    void autoQcnt() {
        do {
            question_counter = Random.Range(0, totalQnum - 1);
        } while (pre_question_counter == question_counter);
        pre_question_counter = question_counter;
    }

    void HideSpeak()
    {
        SpriteRenderer sprender = GameObject.Find("correct_Ans").GetComponent<SpriteRenderer>();
        sprender.enabled = false;
        sprender = GameObject.Find("wrong_Ans").GetComponent<SpriteRenderer>();
        sprender.enabled = false;

    }

    void enableButtonslater(int i) {
        disableButtons();
        Invoke("enableButtons", i);
    }

    void enableButtons()
    {
        button1.GetComponent<Button>().interactable = true;
        button2.GetComponent<Button>().interactable = true;
        button3.GetComponent<Button>().interactable = true;
    }

    void disableButtons() {
        button1.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = false;
        button3.GetComponent<Button>().interactable = false;
    }

}


