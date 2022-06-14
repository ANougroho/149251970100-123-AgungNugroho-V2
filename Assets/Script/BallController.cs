using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    public ScoreManager score;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;

        int roll = Random.Range(0, 2);
        if (roll == 0){
            rig.velocity = speed * 1;
        }
        else {
            rig.velocity = speed * -1;
        }
    }

    public void ResetBall()
    {
        if (score.towardsPlayer == true)
        { rig.velocity = speed * -1;}
        else { rig.velocity = speed * 1; }
    transform.position = new Vector3(resetPosition.x, resetPosition.y, -5);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
