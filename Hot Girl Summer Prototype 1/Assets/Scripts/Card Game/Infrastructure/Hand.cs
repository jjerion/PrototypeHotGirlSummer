using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
    public List<Card> cardsInHand;
    public List<RectTransform> handTransforms;


    public Card PlayFromHand(Card cardToPlay)
    {
        cardsInHand.Remove(cardToPlay);
        GameObject.Destroy(cardToPlay.cardOnScreen.cardDisplay);
        Services.encounter.Play(cardToPlay);

        return cardToPlay;
    }

    public Card Discard(Card cardToDiscard)
    {
        cardsInHand.Remove(cardToDiscard);
        GameObject.Destroy(cardToDiscard.cardOnScreen.cardDisplay);
        return cardToDiscard;
    }

    public Card AddToHand(Card cardToAdd)
    {
        cardsInHand.Add(cardToAdd);
        Object.Instantiate<GameObject>(cardToAdd.cardOnScreen.cardDisplay, Encounter.cardGUI.transform);
        return cardToAdd;
    }
}
