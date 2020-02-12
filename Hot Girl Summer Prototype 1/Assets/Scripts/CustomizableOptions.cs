using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class CustomizableOptions : MonoBehaviour
{
    public string streamingPath;
    public static DataHolder featureSprites;
    public static Characteristic currentlyDisplayed;
    private static SpriteRenderer[] optionSprites;


    // Start is called before the first frame update
    void Awake()
    {
        featureSprites = new DataHolder();
        streamingPath = Path.Combine(Application.streamingAssetsPath, "CustomizableOptions.json");

        StreamReader reader = new StreamReader(streamingPath);

        string fileContents = reader.ReadToEnd();

        featureSprites = DataHolder.CreateFromJSON(fileContents);

        optionSprites = gameObject.GetComponentsInChildren<SpriteRenderer>();
    }

    public static void DisplayOptions(Characteristic feature) 
    {
        currentlyDisplayed = feature;
        for (int i = 0; i < optionSprites.Length; i++)
        {
            optionSprites[i].sprite = feature.spritesOnDisplay[i];
        }

    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
