using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isWinner;
    public static int coinCount;
    public static bool jumptutorial;
    public static bool doublejumptutorial;
    public static bool coincollectutorial;
    public int characterIndex;
    public static float jumptimeRemaining = 3f;
    public static float doublejumptimeRemaining = 3f;
    public static float coincollecttimeRemaining = 3f;
    public Vector2 position = new Vector2(-4, 4);
    public GameObject tutorialManager;
    public CinemachineVirtualCamera VirtualCam;
    public Text coinText;
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject door;
    public GameObject[] players;

    private bool isDoorDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        isWinner = false;
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player = Instantiate(players[characterIndex], position, Quaternion.identity);
        VirtualCam.m_Follow = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinCount.ToString();

        if (coinCount == 20 && !isDoorDestroyed)
        {
            isDoorDestroyed = true;
            Destroy(door);
        }


        if (isGameOver)
        {
            gameOverScreen.SetActive(isGameOver);
        }

        if (isWinner)
        {
            winScreen.SetActive(isWinner);
        }
    }
}
