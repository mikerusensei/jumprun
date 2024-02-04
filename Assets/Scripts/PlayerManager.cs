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
    public Vector2 position = new Vector2(-3, 0);
    public CinemachineVirtualCamera VirtualCam;
    public Text coinText;
    public GameObject gameOverScreen;
    public GameObject winScreen;
    public GameObject jumpTutorialScreen;
    public GameObject doublejumpTutorialScreen;
    public GameObject coinCollectScreen;
    public GameObject door;
    public GameObject[] players;

    private bool isDoorDestroyed;

    private void Awake()
    {
        isGameOver = false;
        jumptutorial = false;
        isWinner = false;
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player = Instantiate(players[characterIndex], position, Quaternion.identity);
        VirtualCam.m_Follow = player.transform;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (jumptutorial)
        {
            jumpTutorialScreen.SetActive(true);
            jumptimeRemaining -= Time.deltaTime;

            if (jumptimeRemaining <= 0)
            {
                jumptutorial = false;
                jumpTutorialScreen.SetActive(jumptutorial);
            }
        }

        if (doublejumptutorial)
        {
            doublejumpTutorialScreen.SetActive(doublejumptutorial);
            doublejumptimeRemaining -= Time.deltaTime;

            if(doublejumptimeRemaining <= 0)
            {
                doublejumptutorial = false;
                doublejumpTutorialScreen.SetActive(doublejumptutorial);
                
            }
        }

        if (coincollectutorial)
        {
            coinCollectScreen.SetActive(coincollectutorial);
            coincollecttimeRemaining -= Time.deltaTime;

            if(coincollecttimeRemaining <= 0)
            {
                coincollectutorial = false;
                coinCollectScreen.SetActive(coincollectutorial);
            }
        }
        
    }

    public void Exit_Button()
    {
        if (jumptutorial)
        {
            jumptutorial = false;
            jumpTutorialScreen.SetActive(jumptutorial);
        }

        if (doublejumptutorial)
        {
            doublejumptutorial = false;
            doublejumpTutorialScreen.SetActive(doublejumptutorial);
        }

        if (coincollectutorial)
        {
            coincollectutorial = false;
            coinCollectScreen.SetActive(coincollectutorial);
        }
    }
}
