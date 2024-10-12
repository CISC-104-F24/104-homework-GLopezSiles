using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //Public variables that can tweaked in Unity Inspector
    public float moveSpeed = 5.0f;
    public float jumpPower = 10.0f;
 
    // Start is called before the first frame update
    void Start()
    {
        bool is_up_pressed;
            is_up_pressed = Input.GetKeyDown(KeyCode.UpArrow);
          //move one unit forward (z-axis) PER SECOND from current position
            transform.position=transform.position+new Vector3(0,0,1)* moveSpeed * Time.deltaTime;
        Rigidbody myRigidBody = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
