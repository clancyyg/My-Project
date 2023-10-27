using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    
    public static Items[] itemsList;

    public void GetItemIIndex()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        itemsList = new Items[2];

        Items item1 = new Items();
        item1.amount = 0;
        item1.name = "TikTok";
        item1.description = "A short video APP, which can make people feel happy and lost focus ability";

        Items item2 = new Items();
        item2.amount = 0;
        item2.name = "Youtube";
        item2.description = "A Video website, providing funny things";

        itemsList[0] = item1;
        itemsList[1] = item2;
        Debug.Log("hello");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
