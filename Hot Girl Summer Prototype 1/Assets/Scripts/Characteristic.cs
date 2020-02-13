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
        int minimumNumberOfDisplayedOptions = Mathf.Min(5, listOfSprites.Length);
        if (isLeft)
        {
            firstSpriteIndex = firstSpriteIndex + 1 % listOfSprites.Length;
            lastSpriteIndex = firstSpriteIndex;
            for (int i = 0; i < minimumNumberOfDisplayedOptions; i++)
            {
                spritesOnDisplay[i] = listOfSprites[lastSpriteIndex];
                lastSpriteIndex = lastSpriteIndex + 1 % listOfSprites.Length;
            }
        }

        else
        {
            firstSpriteIndex = firstSpriteIndex - 1 % listOfSprites.Length;
            lastSpriteIndex = firstSpriteIndex;
            for (int i = 0; i < minimumNumberOfDisplayedOptions; i++)
            {
                spritesOnDisplay[i] = listOfSprites[lastSpriteIndex];
                lastSpriteIndex = lastSpriteIndex + 1 % listOfSprites.Length;
            }
        }
    }
}
