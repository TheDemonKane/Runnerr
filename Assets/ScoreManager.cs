using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Player_Movement player_movement;

    public Text scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreased = 1f;

void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += pointIncreased * Time.fixedDeltaTime;
    }
}
