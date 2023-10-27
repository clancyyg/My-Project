using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContrller : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int playerStatus = PlayerAttributes.domestication;
    public int imageIndex;

    public void UpdateImage()
    {
        if(80<= playerStatus && playerStatus < 90)
        {
            imageIndex = 0;
            spriteRenderer.sprite = spriteArray[imageIndex];
        }
        else if(90<= playerStatus && playerStatus < 100)
        {
            imageIndex = 1;
            spriteRenderer.sprite = spriteArray[imageIndex];
        }
        else if(100<= playerStatus && playerStatus <110)
        {
            imageIndex = 2;
            spriteRenderer.sprite = spriteArray[imageIndex];
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        playerStatus = PlayerAttributes.domestication;
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateImage();
    }

    // Update is called once per frame
    void Update()
    {
        playerStatus = PlayerAttributes.domestication;
        UpdateImage();
    }
}
