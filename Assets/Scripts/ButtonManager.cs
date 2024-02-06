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

    public void Level_Two()
    {
        SceneManager.LoadScene("Level02");
    }

    public void Level_Three()
    {
        SceneManager.LoadScene("Level03");
    }

    public void Level_Four()
    {
        SceneManager.LoadScene("Level04");
    }

    public void Level_Five()
    {
        SceneManager.LoadScene("Level05");
    }
}
