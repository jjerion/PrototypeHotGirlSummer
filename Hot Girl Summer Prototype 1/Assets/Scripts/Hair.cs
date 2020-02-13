using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : Characteristic
{
    public Hair()
    {
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Hair;
        listOfSprites = new Sprite[listOfSpriteNames.Length];
        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            Debug.Log(listOfSpriteNames[i]);
            listOfSprites[i] = Resources.Load<Sprite>("Hair/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
    }
}
