 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    //player is 1. 2 for 2 players 4 for multi 
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject playerThree;
    public GameObject playerFour;
    //for zombies
    public GameObject playerFive;
    public GameObject playerSix;

    public Health HealthP1;
    public Health HealthP2;
    public Health HealthP3;
    public Health HealthP4;
    //for zombies
    public Health HealthP5;
    public Health HealthP6;

    public Image HBar1;
    public Image HBar2;
    public Image HBar3;
    public Image HBar4;

    void Start()
    {
        HealthP1 = playerOne.GetComponent<Health>();
        HealthP2 = playerTwo.GetComponent<Health>();
        HealthP3 = playerThree.GetComponent<Health>();
        HealthP4 = playerFour.GetComponent<Health>();
    }

    void Update()
    {
        HBar1.fillAmount = HealthP1.health / 100;
        HBar2.fillAmount = HealthP2.health / 100;
        HBar3.fillAmount = HealthP3.health / 100;
        HBar4.fillAmount = HealthP4.health / 100;
    }
}
