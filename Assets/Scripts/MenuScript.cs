using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void SinglePlayer()
    {
        //SceneManager.LoadScene("LevelDesign", LoadSceneMode.Single);

    }

    public void DuoPlayer()
    {
        //SceneManager.LoadScene("EvansBonusLevel", LoadSceneMode.Single);

    }

    public void TrioPlayer()
    {
       // SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void QuadPlayer()
    {
        //SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Debug.Log("Ded");
        Application.Quit();
    }
}