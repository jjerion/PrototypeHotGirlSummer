using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckList
{
    public List<Card> allCards;
    public Card.VictoryPoints victoryPoints;

    public Card AddCard(Card cardToAdd)
    {
        return cardToAdd;
    }

    public Card RemoveCard(Card cardToRemove)
    {
        return cardToRemove;
    }
}
