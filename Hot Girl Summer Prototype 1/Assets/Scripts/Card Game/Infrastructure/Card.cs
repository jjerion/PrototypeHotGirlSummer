using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Card
{
    public struct CardInfo
    {
        public string cardName;
        public int type;
        public int value;
        public bool isPlayable;
        public string text;
        public Sprite art;
        public VictoryPoints buyCost;

    }

    public struct VictoryPoints
    {
        public int calmPoints;
        public int bubblyPoints;
        public int hypePoints;
        public int totalPoints;
    }

    public enum Vibes
    {
        Calm,
        Bubbly,
        Hype
    }

    public CardInfo displayedInfo;

    public abstract void Effect();

    public class DisplayedCard : MonoBehaviour
    {
        private readonly GameObject cardDisplay = Resources.Load<GameObject> ("Basic Card");
        private CardInfo _displayedInfo;
        
        //Parent Object
        private RectTransform cardPosition;
        private CanvasRenderer cardRenderer;
        private UnityEngine.UI.Image cardImage;
        //card Name
        private RectTransform namePosition;
        private CanvasRenderer nameRenderer;
        private TextMeshPro nameText;
        //card text
        private RectTransform effectPosition;
        private CanvasRenderer effectRenderer;
        private TextMeshPro effectText;

        public DisplayedCard(CardInfo displayedInfo)
        {
            _displayedInfo = displayedInfo;
            cardDisplay = Resources.Load<GameObject>("Basic Card");
            //Initialize attributes according to Prefab
            cardPosition = cardDisplay.GetComponent<RectTransform>();
            cardRenderer = cardDisplay.GetComponent<CanvasRenderer>();
            cardImage = cardDisplay.GetComponent<UnityEngine.UI.Image>();

            RectTransform[] childPositions = cardDisplay.GetComponentsInChildren<RectTransform>();
            namePosition = childPositions[0];
            effectPosition = childPositions[1];

            CanvasRenderer[] childRenderers = cardDisplay.GetComponentsInChildren<CanvasRenderer>();
            nameRenderer = childRenderers[0];
            effectRenderer = childRenderers[1];


            TextMeshPro[] childTexts = cardDisplay.GetComponentsInChildren<TextMeshPro>();
            nameText = childTexts[0];
            effectText = childTexts[1];

            //Make Attributes represent card info
            
            nameText.text = _displayedInfo.cardName;
            effectText.text = _displayedInfo.text;

            switch (_displayedInfo.type)
            {
                case (int)Vibes.Bubbly:
                    cardImage.sprite = Resources.Load<Sprite>("Cards/Bubbly_Background");
                    break;
                case (int)Vibes.Calm:
                    cardImage.sprite = Resources.Load<Sprite>("Cards/Calm_Background");
                    break;
                case (int)Vibes.Hype:
                    cardImage.sprite = Resources.Load<Sprite>("Cards/Hype_Background");
                    break;
                default:
                    break;

            }
            //Instantiate object
            Object.Instantiate(cardDisplay);


        }

        public void ChangeTransform(Transform newTransform)
        {

        }
    }


}
