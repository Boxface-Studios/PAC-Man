using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConditions : MonoBehaviour
{
    public float bulletCounter;
    public float pacCounter;
    public float zombieCounter;
    public float delayBetweenCheckingWinConditionsCompleted = 1f;

    void Update()
    {
        Invoke("CheckWinConditions", delayBetweenCheckingWinConditionsCompleted);
    }
    public void CheckWinConditions()
    {
        bulletCounter = GameObject.FindGameObjectsWithTag("Bullet").Length;
        pacCounter = GameObject.FindGameObjectsWithTag("PACMAN").Length;
        zombieCounter = GameObject.FindGameObjectsWithTag("Zombie").Length;

        if (bulletCounter == 0)
        {
            BulletWin();
}

        if (pacCounter == 0)
        {
            PacDead();
        }

        if (zombieCounter == 0)
        {
            ZombiesDead();
        }
    }



    //PAC win Condition
    public void BulletWin()
    {

    }
    //Zombies win condition
    public void PacDead()
    {

    }
    //PAC alt win condition
    public void ZombiesDead()
    {

    }
}
