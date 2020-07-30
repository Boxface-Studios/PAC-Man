using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SAE;

public class BasicControls : MonoBehaviour
{
    public enum TargetPlatform { PC, Controller, Arcade }
    [SerializeField] TargetPlatform targetPlatform;

    [SerializeField] private float speed = 10;
    private float hAxis;
    private float vAxis;

    public enum FacingDirection { Up, Down, Left, Right }
    [SerializeField] private FacingDirection facingDirection = FacingDirection.Up;
    Vector3 upDirection = new Vector3(0, 0, 0);
    Vector3 downDirection = new Vector3(0, 180, 0);
    Vector3 leftDirection = new Vector3(0, -90, 0);
    Vector3 rightDirection = new Vector3(0, 90, 0);


    public enum PlayerColorId { UNKNOWN, YELLOW_PLAYER, BLUE_PLAYER, RED_PLAYER, GREEN_PLAYER }
    private PlayerColorId playerColor;

    [Header("DO NOT CHANGE")]
    [SerializeField] private int playerNumber;

    private Rigidbody rb;
    Vector3 MovementVector;

    [SerializeField] float inputFloatError = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetColor(PlayerColorId newColor)
    {
        playerColor = newColor;
    }

    public PlayerColorId GetColor()
    {
        return playerColor;
    }

    /*
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + MovementVector);
        rb.MoveRotation(Quaternion.LookRotation(MovementVector, Vector3.up));
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (targetPlatform == TargetPlatform.PC)
        { 
             GetKeyBoardInput();
        }
        else if (targetPlatform == TargetPlatform.Controller)
        {
            GetControllerInput();
        }
        else
        {
            GetArcadeInput();
        }
        MoveCharacter();
        //SetMovementVector();

    }

    void GetKeyBoardInput()
    {
        hAxis = 0f;
        vAxis = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
         {
            vAxis = -1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
         {
            vAxis = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
         {
            hAxis = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
         {
            hAxis = 1f;
        }

        /*
        //default unity input
        hAxis = Input.GetAxis("Horizontal"); 
        vAxis = Input.GetAxis("Vertical");
        Debug.Log("x = " + hAxis + " and y =" + vAxis);
        */
        //arcade machine input
        // hAxis = SAE.ArcadeMachine.PlayerJoystickAxisStatic(PlayerColorId).x;
        // vAxis = SAE.ArcadeMachine.PlayerJoystickAxisStatic(PlayerColorId).y;
        //needs some code to set the playercolorid to this components player number
    }

    private void GetControllerInput()
    {

    }

    private void GetArcadeInput()
    {

    }

    public void MoveCharacter()
    {
        // read joystick haxis and vaxis to get a direction vector (up/down/left/right)
        // if joystick has moved, rotate to that vector
        // add speed*delta time to the new direction vector

        if (hAxis < 0)
        {
            facingDirection = FacingDirection.Left;
            transform.rotation = Quaternion.Euler(leftDirection);
        }
        else if (hAxis > 0)
        {
            facingDirection = FacingDirection.Right;
            transform.rotation = Quaternion.Euler(rightDirection);

        }
        else if (vAxis < 0)
        {
            facingDirection = FacingDirection.Up;
            transform.rotation = Quaternion.Euler(upDirection);

        }
        else if (vAxis > 0)
        {
            facingDirection = FacingDirection.Down;
            transform.rotation = Quaternion.Euler(downDirection);
        }

        // if I'm moving up, down, left or right on this frame
           // move forward in my current direction speed * Time.delatTime

        if (hAxis != 0 || vAxis != 0)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }


    }
    /*
    back Shorthand for writing Vector3(0, 0, -1).
down Shorthand for writing Vector3(0, -1, 0).
forward Shorthand for writing Vector3(0, 0, 1).
left Shorthand for writing Vector3(-1, 0, 0).
negativeInfinity Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).
one Shorthand for writing Vector3(1, 1, 1).
positiveInfinity Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).
right Shorthand for writing Vector3(1, 0, 0).
up Shorthand for writing Vector3(0, 1, 0).
zero Shorthand for writing Vector3(0, 0, 0).
*/

    /*
    public void SetMovementVector()
    {
        MovementVector.Set(hAxis * speed * Time.deltaTime, 0, vAxis * speed * Time.deltaTime);
    }
    */
}