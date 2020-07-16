using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Debug.Log("Zombie bit me");
        }

        if (other.tag == "Pickup")
        {
            Destroy(other.gameObject);
            Debug.Log("pickup get");
        }
    }

}
