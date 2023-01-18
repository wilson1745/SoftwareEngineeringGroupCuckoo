using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_bar : MonoBehaviour {
    public Image healthImage;
    public Text HPtext;

    void Update()
    {
        healthImage.fillAmount = (float)((float)level.base_hp / (float)level.base_original_hp);

        HPtext.text = level.base_hp + " / "+ level.base_original_hp;
    }
}
