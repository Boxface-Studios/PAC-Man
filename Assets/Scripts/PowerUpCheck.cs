using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCheck : MonoBehaviour
{
	public GameObject defaultLight;
	public GameObject powerUpLight;

	public bool hasPowerUp = false;
	public bool powerCD;
	public float powerTimer = 10f;

	void Update()
	{
		//timer cooldown when powerup has been picked up
		if (hasPowerUp == true)
		{
			defaultLight.SetActive(false);
			powerUpLight.SetActive(true);

			powerTimer -= Time.deltaTime;
		}

		//cooldown. reset everything to normal
		if (powerTimer <= 0)
		{
			hasPowerUp = false;
			powerTimer = 10f;
			defaultLight.SetActive(true);
			powerUpLight.SetActive(false);


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
