using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Times : MonoBehaviour
{
    public Text Fen;
    public Text Miao;
    public float MTimer = 60.0f;
    public float FTimer = 1.0f;

    public GameObject l;

    public GameObject bag;

    public Text textComponent1;
    public Text textComponent2;
    public Text textComponent3;

    private void Start()
    {
        FTimer--;
    }

    [System.Obsolete]
    void Update()
    {
        if (bag.active == true)
        {
            textComponent1.color = new Color(textComponent1.color.r, textComponent1.color.g, textComponent1.color.b, 1f);
            textComponent2.color = new Color(textComponent2.color.r, textComponent2.color.g, textComponent2.color.b, 1f);
            textComponent3.color = new Color(textComponent3.color.r, textComponent3.color.g, textComponent3.color.b, 1f);
        }
        else
        {
            textComponent1.color = new Color(textComponent1.color.r, textComponent1.color.g, textComponent1.color.b, 0f);
            textComponent2.color = new Color(textComponent2.color.r, textComponent2.color.g, textComponent2.color.b, 0f);
            textComponent3.color = new Color(textComponent3.color.r, textComponent3.color.g, textComponent3.color.b, 0f);
        }

        Timejishi();
        if (FTimer == 0 && MTimer <= 0)
        {

            l.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    void Timejishi()
    {
        MTimer -= Time.deltaTime;
        if (FTimer != 0 && MTimer <= 0.2)
        {
            FTimer--;
            MTimer = 3;
        }
        Fen.text = FTimer + "";
        Miao.text = (int)MTimer + "";
    }
}

