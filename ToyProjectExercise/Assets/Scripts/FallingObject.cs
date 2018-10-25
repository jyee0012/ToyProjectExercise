using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{

    [SerializeField]
    bool isBad = false, // if is bad then it will do damage
        useCustomGravity = false; // will use basic translate instead of gravity
    [SerializeField]
    int scoreAmount = 100, objDamage = 1;
    [SerializeField]
    float fallSpeed = 2; // fall speed

    public ScoreAndTimer scoreTimer;

    float defaultFallSpeed = 2; // default fall speed
    // Use this for initialization
    void Start()
    {
        // will attempt to use a rigidbody2d if there is one attached to the gameobject
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
            transform.Translate(new Vector3(0, -fallSpeed, 0) * Time.deltaTime);
        }
    }
    // adds points based on player, player num is required while there is a default score amount provided
    void GivePoints(int playerNum, int score = 100)
    {
        
        if (playerNum == 1)
        {
            //ScoreAndTimer.p1Score += score;
            scoreTimer.AddScore(playerNum);
        }
        else if( playerNum == 2)
        {
            //ScoreAndTimer.p2Score += score;
            scoreTimer.AddScore(playerNum);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 9)
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
            Destroy(gameObject);
        }
    }
}
