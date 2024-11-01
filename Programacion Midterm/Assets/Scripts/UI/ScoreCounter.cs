using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        scoreText.text = GameManager.instance.asteroidsDestroyed.ToString();
    }
}
