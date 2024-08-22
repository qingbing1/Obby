using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBridge : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 endPos;

    public Transform player;
    public Transform jiGuan;

    float tolerance = 2f;//距离为1 

    public float moveSpeed = 10f;

    private bool right = true;
    private bool isMove = true;
    void Update()
    {
        //玩家位置
        Vector3 playerPosition = player.transform.position;

        //与机关之间的距离
        float distance = Vector3.Distance(player.position, jiGuan.position);

        //判断桥应该想哪个方向移动
        Vector3 move = right ? endPos - transform.position : startPos - transform.position;

        if (distance < tolerance && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("按到了");
            isMove = false;
        }
        else
        {
            if (move.magnitude < 0.01f && isMove == true) 
            {
                right = !right;
            }
            transform.position += move.normalized * moveSpeed * Time.deltaTime;
        }
    }
}
