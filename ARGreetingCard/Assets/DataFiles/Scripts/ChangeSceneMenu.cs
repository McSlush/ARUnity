using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour {
    
    public void greetingCard()
    {
        SceneManager.LoadScene("GreetingCardScene");
    }

    public void rotateCube()
    {
        SceneManager.LoadScene("RotateCube");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Exit button pressed");
    }

}
