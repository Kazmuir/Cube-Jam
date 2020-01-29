using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPoints : MonoBehaviour
{
    System.Random pointsAssign = new System.Random();
    int[] pointsAmount = { -100, 0, 10, 25, 50, 100 };
    int index;

    void OnMouseDown()
    {
        index = pointsAssign.Next(0, pointsAmount.Length);
        print(pointsAmount[index]);
    }
}
