using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : Characteristic
{
    public Head()
    {
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Head;

        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            listOfSprites[i] = Resources.Load<Sprite>("Head/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
    }
}
