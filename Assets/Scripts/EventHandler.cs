using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EventHandler : MonoBehaviour
{
    public GameObject[] eventList;
    bool[] eventCalled = new bool[4];

    int sanity = PlayerAttributes.sanity;
    int domestication = PlayerAttributes.domestication;
    int crash = PlayerAttributes.crash;
    int mood = PlayerAttributes.mood;
    int actionPoints;

    public void UpdateStatus()
    {
        sanity = PlayerAttributes.sanity;
        domestication = PlayerAttributes.domestication;
        crash = PlayerAttributes.crash;
        mood = PlayerAttributes.mood;
    }

    public int eventTrigger()
    {
        int index = -1;
        switch (domestication)
        {
            case 100:
                index = 0;
                break;
            case 110:
                index = 1;
                break;
            case 120:
                index = 2;
                break;
            case 130:
                index = 3;
                break;
        }
        // Debug.Log(index);
        return index;
    }


    public void CallEvent(int index)
    {
        //Debug.Log(eventList.Length);
        if (index == -1)
        {
            return;
        }
        else
        {
            if (eventCalled[index] == true)
            {
                return;
            }
            else
            {
                eventList[index].SetActive(true);
                eventList[index].transform.localPosition = new Vector3(282, 476, 0);
                eventCalled[index] = true;
            }
        }

    }

    void Start()
    {
        eventTrigger();
        UpdateStatus();
        for (int i = 0; i < eventList.Length; i++)
        {
            eventList[i].SetActive(false);
        }
    }

    void Update()
    {
        eventTrigger();
        UpdateStatus();
        CallEvent(eventTrigger());   
    }

}
