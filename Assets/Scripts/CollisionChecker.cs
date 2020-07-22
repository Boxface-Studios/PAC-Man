using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{

    public int damageDeltToCollision;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("collision");
        Debug.Log(collision.collider.gameObject);

        if (collision.collider.gameObject.GetComponent<Health>())
        {
           
            collision.collider.gameObject.GetComponent<Health>().TakeDamage(damageDeltToCollision);
        }
        

    }



}
