using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteristic 
{
    public Sprite[] listOfSprites;

    public Sprite[] spritesOnDisplay = new Sprite[5];

    protected int firstSpriteIndex;
    protected int lastSpriteIndex;

    public void IncrementDisplay(bool isLeft)
    {
        firstSpriteIndex = firstSpriteIndex + 1 % 5;
        lastSpriteIndex = firstSpriteIndex;
        for (int i = 0; i < 5; i++)
        {
            spritesOnDisplay[i] = listOfSprites[lastSpriteIndex];
            lastSpriteIndex = lastSpriteIndex + 1 % 5;
        }
    }
}
