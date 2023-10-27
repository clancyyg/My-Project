using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class PlayerAttributes : MonoBehaviour
{
    public static int sanity = 45;
    public static int domestication = 90;
    public static int crash = 0;
    public static int mood = 100;
    public static int actionPoints = 100;

    private int isTurnChanged = 1;

    public static void ResetAtrtibutes()
    {
        sanity = 45;
        domestication = 90;
        crash = 0;
        mood = 100;
        actionPoints = 100;
}
    public static bool IsGameOver()
    {
        if(crash == 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void IsTurnChanged()
    {

        if (isTurnChanged != GamesAttributes.currentTurn)
        {
            
            //Judging player's crash value and excute actions that correspondent
            switch (crash)
            {
                case 2:
                    sanity = sanity - 10;
                    isTurnChanged = GamesAttributes.currentTurn;
                    break;
                case 3:
                    sanity = sanity - 10;
                    isTurnChanged = GamesAttributes.currentTurn;
                    break;
                case 4:
                    sanity = sanity - 30;
                    isTurnChanged = GamesAttributes.currentTurn;
                    break;
            }
            
            if (20 <= sanity && sanity < 50)
            {
                crash = crash + 1;
                isTurnChanged = GamesAttributes.currentTurn;
                return;
            }
            else if (0 <= sanity && sanity < 20)
            {
                crash = crash + 2;
                isTurnChanged = GamesAttributes.currentTurn;
                return;
            }
        }
    }

    //Definding player attributes's increase and decrease methods
    public void IncreaseSanity(int amount)
    {
        sanity += amount;
    }

    public void DecreaseSanity(int amount)
    {
        sanity -= amount;
    }

    public void IncreaseDomestication(int amount)
    {
        domestication += amount;
    }

    public void DecreaseDomestication(int amount)
    {
        domestication -= amount;
    }

    public void DecreaseActionPoints(int amount)
    {
        actionPoints -= amount;
    }

    public void IncreaseCrash(int amount)
    {
        crash += amount;
    }

    public void IncreasetMood(int amount)
    {
        mood += amount;
    }

    public void DecreaseMood(int amount)
    {
        mood -= amount;
    }

    void Start()
    {
        IsGameOver();
        IsTurnChanged();
    }

    // Update is called once per frame
    void Update()
    {
        IsTurnChanged();
        IsGameOver();
    }
}
