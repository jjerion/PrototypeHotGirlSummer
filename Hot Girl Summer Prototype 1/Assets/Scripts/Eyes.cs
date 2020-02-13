using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : Characteristic
{
    public Eyes()
    {
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Eyes;

        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            listOfSprites[i] = Resources.Load<Sprite>("Eyes/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
    }
}
