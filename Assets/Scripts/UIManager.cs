using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text sanityText;
    public Text domesticationText;
    public Text crashText;
    public Text moodText;
    public Text actionPointText;
    public Text gameTurnText;

    public Text[] itemsNameText;
    public Text[] itemsDescriptionText;


    public GameObject gameOverPanel;

    int sanity;
    int domestication;
    int crash;
    int mood;
    int actionPoints;
    int currentTurn;
    int totalTurns;


    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
    }
       
    public void ShowGameOverPanel()
    {
        if(PlayerAttributes.IsGameOver())
        {
            gameOverPanel.SetActive(true);
        }
            
    }
    public void UpdateSanity(int sanity)
    {
        sanityText.text = "Sanity:" + sanity.ToString();
    }

    public void UpdateDomestication(int domestication)
    {
        domesticationText.text = "Domestication:" + domestication.ToString();
    }

    public void UpdateCrash(int crash) 
    {
        crashText.text = "Crash:" + crash.ToString();
    }

    public void UpdateMood(int mood)
    {
        moodText.text = "Mood:" + mood.ToString();
    }

    public void UpdateActionPoint(int actionPoint)
    {
        actionPointText.text = "AcctionPoint:" + actionPoints.ToString();
    }

    public void UpdateTurn(int currentTurn, int totalTurns)
    {
        gameTurnText.text = "Turn:" + currentTurn.ToString() + "/" + totalTurns.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
;
        sanity = PlayerAttributes.sanity;
        domestication = PlayerAttributes.domestication;
        crash = PlayerAttributes.crash;
        mood = PlayerAttributes.mood;
        actionPoints = PlayerAttributes.actionPoints;
        currentTurn = GamesAttributes.currentTurn;
        totalTurns = GamesAttributes.totalTurns;
        UpdateSanity(sanity);
        UpdateDomestication(domestication);
        UpdateCrash(crash);
        UpdateMood(mood);
        UpdateActionPoint(actionPoints);
        UpdateTurn(currentTurn, totalTurns);
        gameOverPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        sanity = PlayerAttributes.sanity;
        domestication = PlayerAttributes.domestication;
        crash = PlayerAttributes.crash;
        mood = PlayerAttributes.mood;
        actionPoints = PlayerAttributes.actionPoints;
        currentTurn = GamesAttributes.currentTurn;
        totalTurns = GamesAttributes.totalTurns;
        UpdateSanity(sanity);
        UpdateDomestication(domestication);
        UpdateCrash(crash);
        UpdateMood(mood);
        UpdateActionPoint(actionPoints);
        UpdateTurn(currentTurn, totalTurns);
        ShowGameOverPanel();
    }
}
