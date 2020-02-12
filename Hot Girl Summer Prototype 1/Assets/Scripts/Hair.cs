using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hair : Characteristic
{
    public Hair()
    {
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Hair;

        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            listOfSprites[i] = Resources.Load<Sprite>("Eyes/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
    }
}
