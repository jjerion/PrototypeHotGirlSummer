using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    
    public List<Card> cardsInDeck;
    public DeckList DeckList;
    
    public Card Draw()
    {
        return cardsInDeck[1];
    }
    

    public Card AddToDeck(Card cardToAdd, int targetPosition = -1)
    {
        return cardToAdd;
    }

    public Card RemoveFromDeck(Card cardToRemove)
    {
        return cardToRemove;
    }

    public void Shuffle()
    {

    }


}
