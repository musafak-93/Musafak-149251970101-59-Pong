using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Musafak-149251970101-59");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Musafak");
    }
}
