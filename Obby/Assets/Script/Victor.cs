using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victor : MonoBehaviour
{

    float targetz = 270f;

    void Update()
    {
        if (Mathf.Abs(gameObject.transform.position.z - targetz) < 0.1)
        {
            Debug.Log("Victor");
            GetComponent<Animator>().SetBool("Victor", true);
        }
    }
}
