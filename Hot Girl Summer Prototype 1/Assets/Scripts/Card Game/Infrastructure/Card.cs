using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public class DisplayedCard
    {

        private CardInfo _displayedInfo;

        public DisplayedCard(CardInfo displayedInfo, Transform transform)
        {
            _displayedInfo = displayedInfo;

        }

        public void ChangeTransform(Transform newTransform)
        {

        }
    }


}
