using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController cc;

    public float moveSpeed;//移动速度

    private float horizontalMove, verticalMove;//获取按键值的变量

    private Vector3 dir;//方向

    public float gravity;//重力

    private Vector3 velocity;//y轴加速度


    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;//锁定鼠标
    }


    void Update()
    {
        MouseControl();
        if (velocity.y < 0)
        {
            velocity.y = -1f;
        }
        horizontalMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horizontalMove;

        cc.Move(dir * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);

        //是否按下移动键
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 8;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                moveSpeed = 5;
            }
        }

        if (gameObject.transform.position.y < -5f)
        {
            gameObject.transform.position = new Vector3(-3,1.5f,-1.83f);
        }
    }
    public void MouseControl()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
