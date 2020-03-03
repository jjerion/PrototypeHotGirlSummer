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

        //handTransforms.RemoveAt(0);
        //Services.encounter.UpdateHandSize();

        GameObject.Destroy(cardToPlay.cardOnScreen.cardDisplay);
        //Services.encounter.UpdateCardGameObjects();
        Services.encounter.Play(cardToPlay);

        return cardToPlay;
    }

    public Card Discard(Card cardToDiscard)
    {
        cardsInHand.Remove(cardToDiscard);

        //handTransforms.RemoveAt(0);
        //Services.encounter.UpdateHandSize();

        GameObject.Destroy(cardToDiscard.cardOnScreen.cardDisplay);
        //Services.encounter.UpdateCardGameObjects();
        
        
        return cardToDiscard;
    }

    public Card AddToHand(Card cardToAdd)
    {
        cardsInHand.Add(cardToAdd);
        handTransforms.Add(new RectTransform());
        Services.encounter.UpdateHandSize();
        Services.encounter.UpdateCardGameObjects();
        GameObject cardToDisplay = cardToAdd.cardOnScreen.cardDisplay;
        Object.Instantiate<GameObject>(cardToAdd.cardOnScreen.cardDisplay, Vector3.zero, Quaternion.identity, Encounter.cardGUI.transform);
        cardToDisplay.GetComponent<DisplayedCard>().card = cardToAdd;
        return cardToAdd;
    }
}
