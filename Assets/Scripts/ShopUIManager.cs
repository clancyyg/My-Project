using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    public Text[] itemsNameText;
    public Text[] itemsDescriptionText;

    public void ShowItems(Items[] item)
    {
        for (int i = 0; i < item.Length; i++)
        {
            itemsNameText[i].text = item[i].name;
            itemsDescriptionText[i].text = item[i].description;
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
        ShowItems(ShopManager.itemsList);

    }

    // Update is called once per frame
    void Update()
    {
        ShowItems(ShopManager.itemsList);
    }
}
