using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Animator playerAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Traps")
        {
            PlayerManager.isGameOver = true;
            PlayerManager.coinCount = 0;
            playerAnim.SetTrigger("Death");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Jump Tutorial Sign")
        {
            PlayerManager.jumptutorial = true;
            PlayerManager.jumptimeRemaining = 3;
        }
        
        if (collision.transform.tag == "Double Jump Sign")
        {
            PlayerManager.doublejumptutorial = true;
            PlayerManager.doublejumptimeRemaining = 3;
        }

        if (collision.transform.tag == "Collect Coin Sign")
        {
            PlayerManager.coincollectutorial = true;
            PlayerManager.coincollecttimeRemaining = 3;
        }

        if (collision.transform.tag == "Flag")
        {
            PlayerManager.isWinner = true;
        }
    }
}
