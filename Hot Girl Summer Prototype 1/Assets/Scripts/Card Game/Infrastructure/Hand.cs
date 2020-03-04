using System.Collections;
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

        cardToPlay.cardGameObject.SetActive(false);
        //Services.encounter.UpdateCardGameObjects();
        Services.encounter.Play(cardToPlay);

        return cardToPlay;
    }

    public Card Discard(Card cardToDiscard)
    {
        cardsInHand.Remove(cardToDiscard);

        //handTransforms.RemoveAt(0);
        //Services.encounter.UpdateHandSize();

        GameObject.Destroy(cardToDiscard.cardGameObject);
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
        Debug.Assert(cardToAdd.cardGameObject != null, "cardOnScreen is null");
        //Debug.Assert(cardToAdd.cardOnScreen.cardGameObject != null, "cardDisplay is null");

        Debug.Log(Encounter.cardGUI.gameObject.name);

        //GameObject newGameObject = Object.Instantiate<GameObject>(cardToAdd.cardGameObject, Vector3.zero, Quaternion.identity, Encounter.cardGUI.transform);
        //newGameObject.SetActive(true);
        //Debug.Log(newGameObject.name);
        cardToAdd.cardGameObject.transform.SetParent(Encounter.cardGUI.transform);
        cardToAdd.cardGameObject.SetActive(true);
        Debug.Log("Activated object");
        //newGameObject.AddComponent<CardIdentifier>().whichCardIsThis = cardToAdd;
        return cardToAdd;
    }
}
