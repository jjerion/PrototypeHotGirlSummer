using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : Characteristic
{

    public Mouth()
    {
        string[] listOfSpriteNames = CustomizableOptions.featureSprites.Mouth;

        for (int i = 0; i < listOfSpriteNames.Length; i++)
        {
            listOfSprites[i] = Resources.Load<Sprite>("Mouth/" + listOfSpriteNames[i]);
        }

        firstSpriteIndex = 0;
        lastSpriteIndex = 4;
    }
}
