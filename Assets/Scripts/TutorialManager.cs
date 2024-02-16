using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject jumpTutorialScreen;
    public GameObject doublejumpTutorialScreen;
    public GameObject coinCollectScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.jumptutorial)
        {
            jumpTutorialScreen.SetActive(PlayerManager.jumptutorial);
            PlayerManager.jumptimeRemaining -= Time.deltaTime;

            if (PlayerManager.jumptimeRemaining <= 0)
            {
                PlayerManager.jumptutorial = false;
                jumpTutorialScreen.SetActive(PlayerManager.jumptutorial);
            }
        }

        if (PlayerManager.doublejumptutorial)
        {
            doublejumpTutorialScreen.SetActive(PlayerManager.doublejumptutorial);
            PlayerManager.doublejumptimeRemaining -= Time.deltaTime;

            if (PlayerManager.doublejumptimeRemaining <= 0)
            {
                PlayerManager.doublejumptutorial = false;
                doublejumpTutorialScreen.SetActive(PlayerManager.doublejumptutorial);

            }
        }
        if (PlayerManager.coincollectutorial)
        {
            coinCollectScreen.SetActive(PlayerManager.coincollectutorial);
            PlayerManager.coincollecttimeRemaining -= Time.deltaTime;

            if (PlayerManager.coincollecttimeRemaining <= 0)
            {
                PlayerManager.coincollectutorial = false;
                coinCollectScreen.SetActive(PlayerManager.coincollectutorial);
            }
        }
    }
}
