using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControls : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody player1;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        player1.MovePosition(transform.position + movement);
    }
}
