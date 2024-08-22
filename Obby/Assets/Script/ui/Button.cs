using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Bag;

    public GameObject oK;

    public void OnButton()
    {
        Bag.SetActive(true);
    }

    public void Close()
    {
        Bag.SetActive(false);
    }

    public void OK()
    {
        gameObject.SetActive(false);
        oK.SetActive(true);
        Debug.Log("你成功领取了n号物品.");
    }
}
