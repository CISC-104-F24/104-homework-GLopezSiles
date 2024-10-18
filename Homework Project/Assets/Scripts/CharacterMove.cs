using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
   

    //Public variables that can tweaked in Unity Inspector
    public float moveSpeed = 5.0f;
    public float jumpPower = 10.0f;
    public float SprintSpeed = 50.0f;

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool is_w_pressed;
        is_w_pressed = Input.GetKeyDown(KeyCode.W);
        if (is_w_pressed)


            //move one unit forward (z-axis) PER SECOND from current position
            transform.position = transform.position + moveSpeed * Time.deltaTime * new Vector3(0, 0, 1);

        bool is_s_pressed;
        is_s_pressed = Input.GetKeyDown(KeyCode.S);
        if (is_s_pressed)



            transform.position = transform.position + moveSpeed * Time.deltaTime * new Vector3(0, 0, -1);

        bool is_d_pressed;
        is_d_pressed = Input.GetKeyDown(KeyCode.D);
        if (is_d_pressed)



            transform.position = transform.position + moveSpeed * Time.deltaTime * new Vector3(1, 0, 0);


        bool is_a_pressed;
        is_a_pressed = Input.GetKeyDown(KeyCode.A);
        if (is_a_pressed)


            transform.position = transform.position + moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0);



        bool is_jump_pressed;
        is_jump_pressed = Input.GetKeyDown(KeyCode.Space);
        if (is_jump_pressed)


        {
            Rigidbody myRigidbody = GetComponent<Rigidbody>();
            myRigidbody.AddForce(new Vector3(0, 1, 0) * jumpPower, ForceMode.Impulse);









            bool is_Shift_pressed;
            is_Shift_pressed = Input.GetKeyDown(KeyCode.LeftShift);
            if (is_Shift_pressed)

                transform.position = transform.position + (SprintSpeed * Time.deltaTime * new Vector3(5, 0, 0));





        }
    }
}





