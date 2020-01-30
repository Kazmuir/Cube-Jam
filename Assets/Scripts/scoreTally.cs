using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreTally : MonoBehaviour
{
    public static scoreTally sT;
    public bool goalReached = false;
    void Awake()
    {
        sT = this;
    }

    TextMeshProUGUI score;
    int totalScore;
    private void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }
    public void calculateTotalScore(int points)
    {
        totalScore += points;
        score.text = "Score: " + totalScore;
    }

    private void Update()
    {
        checkProgress();
    }

    void checkProgress()
    {
        if(totalScore >= 1000)
        {
            goalReached = true;
        }
    }
}
