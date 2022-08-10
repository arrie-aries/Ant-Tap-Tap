using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Arrie M Aries Sharief - BDI07");
    }
    public void Quitgame()
    {
        {
            Application.Quit();
        }
    }
}
