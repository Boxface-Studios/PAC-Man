using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (this.tag == "PACMAN")
        {
            if (other.tag == "Pickup")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
