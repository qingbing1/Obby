using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;

    private float mouseX, mouseY;//获取鼠标移动的值
    public float mouseSensitivity;//鼠标灵敏

    public float xRotation;// 用来累加mouseY

    float onetargetz = 218f;
    float threetargetz = 250f;
    float tolerance = 0.1f;//误差值

    private void Update()
    {
        Vector3 playerposition = player.transform.position;
        //鼠标左右移动的值
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //鼠标上下移动的值
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -60, 30);//限制y轴角度

        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        if(Mathf.Abs(playerposition.z - onetargetz) < tolerance)
        {
            gameObject.transform.localPosition = new Vector3(0,1,0);
            gameObject.transform.rotation = Quaternion.identity;
        }
        if (Mathf.Abs(playerposition.z - threetargetz) < tolerance)
        {
            gameObject.transform.localPosition = new Vector3(0, 1.5f, -4);
            gameObject.transform.rotation = Quaternion.identity;
        }
    }
}
