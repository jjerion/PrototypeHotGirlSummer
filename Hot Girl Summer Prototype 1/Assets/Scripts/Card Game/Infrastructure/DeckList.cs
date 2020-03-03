using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckList
{
    public List<Card> allCards;
    public static Card.VictoryPoints victoryPoints;

    public DeckList()
    {
        allCards = new List<Card>();
        
    }
    public Card AddCard(Card cardToAdd)
    {
        allCards.Add(cardToAdd);
        return cardToAdd;
    }

    public Card RemoveCard(Card cardToRemove)
    {
        allCards.Remove(cardToRemove);
        return cardToRemove;
    }
}
