using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayerController : MonoBehaviour
{
    private enum Player
    {
        Player1,
        Player2
    }
    [SerializeField]
    private Player player;
    [SerializeField]
    private float speed, jumpForce;
    [SerializeField]
    private const int maxHP = 5;
    private int health;
    private float vinput;
    private string vinputString;
    private KeyCode jump;
    // Use this for initialization
    void Start()
    {
        switch (player)
        {
            case Player.Player1:
                vinputString = "Horizontalp1";
                jump = KeyCode.W;
                break;
            case Player.Player2:
                vinputString = "Horizontalp2";
                jump = KeyCode.UpArrow;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        vinput = Input.GetAxis(vinputString);
        transform.Translate(vinput * Time.deltaTime * speed, 0, 0);
    }

    public int GetPlayer()
    {
        int num;
        switch (player)
        {
            case Player.Player1:
                num = 1;
                break;
            case Player.Player2:
                num = 2;
                break;
            default:
                num = 0;
                break;
        }
        return num;
    }
    public void TakeDamage(int num)
    {
        health -= num;
    }
}
