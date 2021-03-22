using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode down;
    public Rigidbody rbPlayer;
    public Vector2 leftPower;
    public Vector2 rightPower;
    public Vector2 jumpPower;
    public Vector2 downPower;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            rbPlayer.AddForce(leftPower);
        }

        if (Input.GetKeyDown(right))
        {
            rbPlayer.AddForce(rightPower);
        }

        
        if (Input.GetKeyDown(down))
        {
            rbPlayer.AddForce(downPower);
        }


        if (Input.GetKeyDown(jump))
        {
            rbPlayer.AddForce(jumpPower);
        }
    }
     
}
