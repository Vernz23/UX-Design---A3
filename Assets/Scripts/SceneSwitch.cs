using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void sceneOne()
    {
        SceneManager.LoadScene("SceneOne");
    }


    public void sceneTwo()
    {
        SceneManager.LoadScene("SceneTwo");
    }

    public void sceneThree()
    {
        SceneManager.LoadScene("SceneThree");
    }

    public void sceneFour()
    {
        SceneManager.LoadScene("SceneFour");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void credits() {
        SceneManager.LoadScene("Credits");
    
    }

    
}
