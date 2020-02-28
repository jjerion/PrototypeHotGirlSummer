using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
    public List<Card> cardsInHand;
    public List<GameObject> cardSprites;


    public Card PlayFromHand(Card cardToPlay)
    {
        cardToPlay.Effect();

        return cardToPlay;
    }

    public Card Discard(Card cardToDiscard)
    {
        return cardToDiscard;
    }

    public Card AddToHand(Card cardToAdd)
    {
        return cardToAdd;
    }
}
