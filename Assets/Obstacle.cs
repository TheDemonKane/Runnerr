using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player_Movement player_Movement;

    private void Start()
    {
        player_Movement = GameObject.FindObjectOfType<Player_Movement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player_Movement.die();
        }
    }

    private void Update()
    {
        
    }
}
