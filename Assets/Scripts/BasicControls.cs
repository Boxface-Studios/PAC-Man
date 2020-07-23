using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;

public class BasicControls : MonoBehaviour
{
    public float speed = 10;
    float hAxis;
    float vAxis;
    //public enum PlayerColorId { UNKNOWN, YELLOW_PLAYER, BLUE_PLAYER, RED_PLAYER, GREEN_PLAYER }

    public int playerNumber;


    public Rigidbody rb;
    Vector3 MovementVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + MovementVector);
        rb.MoveRotation(Quaternion.LookRotation(MovementVector, Vector3.up));
    }
    // Update is called once per frame
    void Update()
    {
        GetInput();
        SetMovementVector();
    }

    void GetInput()
    {
        //default unity input
        hAxis = Input.GetAxis("Horizontal"); 
        vAxis = Input.GetAxis("Vertical");
        //arcade machine input
        // hAxis = SAE.ArcadeMachine.PlayerJoystickAxisStatic(PlayerColorId).x;
        // vAxis = SAE.ArcadeMachine.PlayerJoystickAxisStatic(PlayerColorId).y;
        //needs some code to set the playercolorid to this components player number



    }

    public void SetMovementVector()
    {
        MovementVector.Set(hAxis * speed * Time.deltaTime, 0, vAxis * speed * Time.deltaTime);
    }

}