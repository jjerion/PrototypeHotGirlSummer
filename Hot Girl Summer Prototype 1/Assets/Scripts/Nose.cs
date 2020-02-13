using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nose : Characteristic
{

    public Nose()
    {
        
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Nose;

        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            listOfSprites[i] = Resources.Load<Sprite>("Nose/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
        
    }
}
