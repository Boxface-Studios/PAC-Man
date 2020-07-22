 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject playerThree;
    public GameObject playerFour;

    public Health HealthP1;
    public Health HealthP2;
    public Health HealthP3;
    public Health HealthP4;

    public Image HBar1;
    public Image HBar2;
    public Image HBar3;
    public Image HBar4;


    // Start is called before the first frame update
    void Start()
    {
        HealthP1 = playerOne.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        HBar1.fillAmount = HealthP1.health / 100;
    }
}
