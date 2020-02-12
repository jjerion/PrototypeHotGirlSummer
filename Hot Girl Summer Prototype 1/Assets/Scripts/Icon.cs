using System.Collections;
using System.Collections.Generic;
using System; 
using UnityEngine;

public class Icon : MonoBehaviour
{

    public string feature;
    private BoxCollider2D iconCollider;
    private SpriteRenderer image;
    public static Characteristic featuredCharacterstic;

    
    void Start()
    {
        iconCollider = gameObject.GetComponent<BoxCollider2D>();
        image = gameObject.GetComponent<SpriteRenderer>();
        featuredCharacterstic = gameObject.GetComponent<Characteristic>();
    }

    private void OnMouseDown()
    {


        //CustomizableOptions.DisplayOptions< Type.GetType(feature) >();
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
