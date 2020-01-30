using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class getPoints : MonoBehaviour
{
    public int cubePointValue;

    System.Random pointsAssign = new System.Random();
    int[] pointsAmount = { 0, 10, 25, 50, 100 };
    private int index;

    private void Start()
    {
        index = pointsAssign.Next(0, pointsAmount.Length);
        cubePointValue = pointsAmount[index];
    }
    void OnMouseDown()
    {
       scoreTally.sT.calculateTotalScore(cubePointValue);
       Destroy(gameObject);
    }
}
