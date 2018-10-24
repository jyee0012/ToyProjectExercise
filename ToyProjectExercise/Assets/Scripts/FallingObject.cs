using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{

    [SerializeField]
    bool isBad = false, useCustomGravity = false;
    [SerializeField]
    int scoreAmount = 100, objDamage = 1;
    [SerializeField]
    float fallSpeed = 2;

    float defaultFallSpeed = 2;
    // Use this for initialization
    void Start()
    {
        if (GetComponent<Rigidbody2D>() != null)
        {
            GetComponent<Rigidbody2D>().gravityScale = fallSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (useCustomGravity)
        {
            transform.Translate(new Vector3(0, fallSpeed, 0) * Time.deltaTime);
        }
    }
    void GivePoints(int playerNum, int score = 100)
    {
        if (playerNum == 1)
        {
            ScoreAndTimer.p1Score += score;
        }
        else if( playerNum == 2)
        {
            ScoreAndTimer.p2Score += score;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (isBad)
            {
                collision.transform.GetComponent<Scr_PlayerController>().TakeDamage(objDamage);
            }
            else
            {
                int currentPlayer = collision.transform.GetComponent<Scr_PlayerController>().GetPlayer();
                GivePoints(currentPlayer, scoreAmount);
            }
        }
    }
}
