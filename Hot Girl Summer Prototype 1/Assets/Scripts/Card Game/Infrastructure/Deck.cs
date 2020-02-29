using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    
    public List<Card> cardsInDeck;
    public DeckList deckList;

    public Deck()
    {
        deckList = GameController.partyDeck;
        cardsInDeck = deckList.allCards;
    }
    
    public Card Draw()
    {
        var cardToDraw = cardsInDeck[0];
        cardsInDeck.RemoveAt(0);
        return Encounter.playerHand.AddToHand(cardToDraw);
    }
    

    public Card AddToDeck(Card cardToAdd, int targetPosition = -1)
    {
        if (targetPosition == -1)
        {
            cardsInDeck.Add(cardToAdd);
            return cardToAdd;
        }
        cardsInDeck.Insert(targetPosition, cardToAdd);
        return cardToAdd;
    }

    public Card RemoveFromDeck(Card cardToRemove)
    {
        cardsInDeck.Remove(cardToRemove);
        return cardToRemove;
    }

    public void Shuffle()
    {
        List<Card> newList = new List<Card>();
        newList = cardsInDeck;
        for (int i = 0; i <cardsInDeck.Count; i++)
        {
            int temporaryInt = (int)Mathf.Floor(Random.Range(0, newList.Count));
            cardsInDeck[i] = newList[temporaryInt];
            newList.RemoveAt(temporaryInt);
        }

    }


}
