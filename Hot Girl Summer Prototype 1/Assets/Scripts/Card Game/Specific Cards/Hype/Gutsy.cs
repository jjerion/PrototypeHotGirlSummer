using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gutsy : Card
{
    public Gutsy()
    {
        displayedInfo.cardName = "Gutsy";
        displayedInfo.type = (int)Vibes.Hype;
        displayedInfo.value = 1;
        displayedInfo.isPlayable = true;
        displayedInfo.text = "Immediately add +2 Hype cards to your deck. At the start of your turn, remove those two hype cards from your deck.";
        displayedInfo.art = Resources.Load<Sprite>("");
    }

    public override void Effect()
    {
        var newCard = new Hype(); //add two hype cards
        Encounter.playerDiscard.AddToDiscard(newCard);
        Encounter.playerDiscard.AddToDiscard(newCard);

        //set to destroy cards after opponent's turn
    }
}
