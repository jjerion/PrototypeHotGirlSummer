using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CustomizableOptions : MonoBehaviour
{
    public string streamingPath;
    public static DataHolder featureSprites;


    // Start is called before the first frame update
    void Start()
    {
        featureSprites = new DataHolder();
        streamingPath = Path.Combine(Application.streamingAssetsPath, "data.json");

        StreamReader reader = new StreamReader(streamingPath);

        string fileContents = reader.ReadToEnd();

        featureSprites = DataHolder.CreateFromJSON(fileContents);
    }

    public static void DisplayOptions<T>() where T : Characteristic
    {
        
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
