using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Button hideButton;
    public Button showButton;
    public GameObject[] addButton;
    public GameObject[] minButton;
    public Button[] eventList;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerAttributes.ResetAtrtibutes();

    }
    public void ShowEvent()
    {
        eventList[ Random.Range(0, eventList.Length)].gameObject.SetActive(false);
    }


    public void HideAddButton()
    {
        for (int i = 0; i < addButton.Length;i++)
        {
            addButton[i].gameObject.SetActive(false);
        }

        ShowMinButton();

    }

    public void ShowAddButton() 
    {
        for (int i = 0; i < addButton.Length; i++)
        {
            addButton[i].gameObject.SetActive(true);
        }

        HideMinButton();
    }

    public void ShowMinButton()
    {
        for (int i = 0; i < minButton.Length; i++)
        {
            minButton[i].gameObject.SetActive(true);
        }
    }

    public void HideMinButton()
    {
        for(int i = 0;i < minButton.Length;i++)
        {
            minButton[i] .gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        minButton = GameObject.FindGameObjectsWithTag("Min");
        addButton = GameObject.FindGameObjectsWithTag("Add");
        HideMinButton();
        hideButton.onClick.AddListener(HideAddButton);
        showButton.onClick.AddListener(ShowAddButton);
        
    }

    // Update is called once per frame
    void Update()
    {
        hideButton.onClick.AddListener(HideAddButton);
        showButton.onClick.AddListener(ShowAddButton);
    }
}
