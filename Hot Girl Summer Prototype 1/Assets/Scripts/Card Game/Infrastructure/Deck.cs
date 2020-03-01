using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    
    public List<Card> cardsInDeck;
    public DeckList DeckList;
    
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

    }


}
