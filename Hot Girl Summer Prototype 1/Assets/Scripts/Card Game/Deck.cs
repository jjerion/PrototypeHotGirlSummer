using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    
    public List<Card> cardsInDeck;
    public DeckList DeckList;

    public Card Draw()
    {

    }
    

    public Card AddToDeck(int targetPosition = -1, Card cardToAdd)
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
