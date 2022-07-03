using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public GameObject paddleLong;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleLong.SetActive(true);
            manager.RemovePowerUp(gameObject);
        }
    }

}
