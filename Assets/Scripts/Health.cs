
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int DamageToTake)
    {
        health -= DamageToTake;
        if (health <= 0)
        {
            Destroy(this.gameObject);

        }
    }

}
