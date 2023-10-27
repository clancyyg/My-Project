using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesAttributes : MonoBehaviour
{
    public static int totalTurns = 10;
    public static int currentTurn = 1;

    public void NextTurn()
    {
        currentTurn++;
        PlayerAttributes.actionPoints = 100;
    }
}
