using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public abstract class Card
{
    //Data Structures
    #region
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
    #endregion


    public CardInfo displayedInfo;
    public DisplayedCard cardOnScreen;
    public abstract void Effect();

    public Card()
    {
        cardOnScreen = new DisplayedCard(this);
    }



}
