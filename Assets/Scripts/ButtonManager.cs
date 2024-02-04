using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ChooseLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void Quit_Game()
    {
        Application.Quit();
    }

    public void Level_One()
    {
        SceneManager.LoadScene("Level01");
    }

}
