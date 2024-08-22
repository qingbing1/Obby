using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;

    private float mouseX, mouseY;//��ȡ����ƶ���ֵ
    public float mouseSensitivity;//�������

    public float xRotation;// �����ۼ�mouseY

    float onetargetz = 218f;
    float threetargetz = 250f;
    float tolerance = 0.1f;//���ֵ

    private void Update()
    {
        Vector3 playerposition = player.transform.position;
        //��������ƶ���ֵ
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        //��������ƶ���ֵ
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -60, 30);//����y��Ƕ�

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
