using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableOptions : MonoBehaviour
{
    public string streamingPath;
    public static DataHolder file;

    // Start is called before the first frame update
    void Start()
    {
        file = new DataHolder();
        streamingPath = Path.Combine(Application.streamingAssetsPath, "data.json");

        StreamReader reader = new StreamReader(streamingPath);

        string fileContents = reader.ReadToEnd();

        file = DataHolder.CreateFromJSON(fileContents);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
