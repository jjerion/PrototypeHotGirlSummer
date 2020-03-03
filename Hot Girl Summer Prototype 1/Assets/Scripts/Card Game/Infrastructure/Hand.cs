﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
    public List<Card> cardsInHand;
    //public List<RectTransform> handTransforms;

    public Hand()
    {
        cardsInHand = new List<Card>();

    }

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
        //handTransforms.Add(new RectTransform());
        Services.encounter.UpdateHandSize();
        Services.encounter.UpdateCardGameObjects();

        Debug.Assert(cardToAdd != null, "cardToAdd is null");
        Debug.Assert(cardToAdd.cardOnScreen != null, "cardOnScreen is null");
        Debug.Assert(cardToAdd.cardOnScreen.cardDisplay != null, "cardDisplay is null");

        Debug.Log(Encounter.cardGUI.gameObject.name);

        GameObject newGameObject = Object.Instantiate<GameObject>(cardToAdd.cardOnScreen.cardDisplay, Vector3.zero, Quaternion.identity, Encounter.cardGUI.transform);
        Debug.Log("instantiated object");
        newGameObject.AddComponent<CardIdentifier>().whichCardIsThis = cardToAdd;
        return cardToAdd;
    }
}
