using System.Collections;
using System.Collections.Generic;
using System; 
using UnityEngine;

public class Icon : MonoBehaviour
{

    private BoxCollider2D iconCollider;
    private SpriteRenderer image;
    public string featureString;
    public struct Features
    {
        public Characteristic featuredCharacteristic;

        public Features(string featureString)
        {
            if (featureString == "Nose")
            {
                featuredCharacteristic = new Nose();
            }
            else if (featureString == "Head")
            {
                featuredCharacteristic = new Head();
            }
            else if (featureString == "Hair")
            {
                featuredCharacteristic = new Hair();
            }
            else if (featureString == "Eyes")
            {
                featuredCharacteristic = new Eyes();
            }
            else if (featureString == "Mouth")
            {
                featuredCharacteristic = new Mouth();
            }
            else featuredCharacteristic = null;
        }

        
    }
    public Features feature;


void Start()
    {
        iconCollider = gameObject.GetComponent<BoxCollider2D>();
        image = gameObject.GetComponent<SpriteRenderer>();
        feature = new Features(featureString);
        
    }

    private void OnMouseDown()
    {


        CustomizableOptions.DisplayOptions(feature.featuredCharacteristic);
    }

    private void OnMouseOver()
    {
        image.color = Color.yellow; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
