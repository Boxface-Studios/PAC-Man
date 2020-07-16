using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControls : MonoBehaviour
{
    public float speed = 10;
    float hAxis;
    float vAxis;

    public Rigidbody player1;
    Vector3 p1MovementVector;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        player1.MovePosition(transform.position + p1MovementVector);
        player1.MoveRotation(Quaternion.LookRotation(p1MovementVector, Vector3.up));
    }
    // Update is called once per frame
    void Update()
    {
        GetInput();

    }

    void GetInput()
    {
        hAxis = Input.GetAxis("Horizontal"); //player1 hAxis
        vAxis = Input.GetAxis("Vertical"); // player1 vAxis
        //set player one movement vector
        p1MovementVector.Set(hAxis * speed * Time.deltaTime, 0, vAxis * speed * Time.deltaTime);
    }
}