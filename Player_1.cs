using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public static Player_1 instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject berry_1;
    private float max_movement = 8f;
    private float move_speed = 18f;

    public int abc;


    void Start()
    {
        //berry_1.transform.Find("main berry_1");

      

    }
    void Update()
    {



        //Movement();
    }
    public void Movement()
    {
        float input_X = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * input_X * move_speed * Time.deltaTime;
        float X_pos = Mathf.Clamp(transform.position.x, -max_movement, max_movement);
        transform.position = new Vector3(X_pos, transform.position.y, transform.position.z);



    }






}
