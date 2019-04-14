using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode down = KeyCode.DownArrow;
    public KeyCode up = KeyCode.UpArrow;

    public float speed;

    public CharacterController controller;

    public static MoveTest instance;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(left))
        {
            movePlayer(-1, 0);
        }
        if(Input.GetKey(right))
        {
            movePlayer(1, 0);
        }
        if(Input.GetKey(up))
        {
            movePlayer(0, 1);
        }
        if(Input.GetKey(down))
        {
            movePlayer(0, -1);
        }
    }

    public void movePlayer (float axisX, float axisY)
    {
        float speedX = 0.0F;
        if (axisX < 0)
        {
            speedX = -1.0F;
        }
        else if (axisX > 0)
        {
            speedX = 1.0F;
        }
        float speedY = 0.0F;
        if (axisY < 0)
        {
            speedY = -1.0F;
        }
        else if (axisY > 0)
        {
            speedY = 1.0F;
        }

        Vector3 velocity = new Vector3
        {
            x = speedX,
            y = 0.0F,
            z = speedY
        };
        controller.SimpleMove(velocity * speed);
    }
}
