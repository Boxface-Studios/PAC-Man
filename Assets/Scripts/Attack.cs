using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public int attackDamage;

    public void OnTriggerEnter(Collider other)
    {
        if (this.tag == "Zombie" && other.tag == "PACMAN")
        {
            if (other.GetComponent<PowerUpCheck>().hasPowerUp == false)
            {
                other.GetComponent<Health>().TakeDamage(attackDamage);
            }
        }

        if (this.tag == "PACMAN" && other.tag == "Zombie")
        {
            if (this.GetComponent<PowerUpCheck>().hasPowerUp == true)
            {
                other.GetComponent<Health>().TakeDamage(attackDamage);
            }
        }
    }
}
