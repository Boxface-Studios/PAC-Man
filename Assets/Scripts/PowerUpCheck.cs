using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCheck : MonoBehaviour
{
	public bool hasPowerUp = false;
	public bool powerCD;
	public float powerTimer = 10f;


	void Update()
	{
		//timer cooldown when powerup has been picked up
		if (hasPowerUp == true)
		{
			powerTimer -= Time.deltaTime;
		}

		//cooldown. reset everything to normal
		if (powerTimer <= 0)
		{
			hasPowerUp = false;
			powerTimer = 10f;

		}

	}

	public void OnTriggerEnter(Collider other)
	{		
	 if (this.tag == "PACMAN")
		{			
		if (other.tag == "PowerUp")
			{				
				hasPowerUp = true;
				//play SE
				Destroy(other.gameObject);
			}
		}
	}

	public bool HasPoweredUp()
	{
		return hasPowerUp;
	}
}
