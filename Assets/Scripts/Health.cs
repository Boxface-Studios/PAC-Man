using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;

    public void TakeDamage(int DamageToTake)
    {
        health -= DamageToTake;
        if (health <= 0)
        {
            Destroy(this.gameObject);

        }
    }

}