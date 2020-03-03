using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPumped : Card
{
    public GetPumped()
    {
        displayedInfo.cardName = "Get Pumped";
        displayedInfo.type = (int)Vibes.Hype;
        displayedInfo.value = 1;
        displayedInfo.isPlayable = true;
        displayedInfo.text = "Gain +2 Actions this turn. Discard 1 card from your hand.";
        displayedInfo.art = Resources.Load<Sprite>("");
    }

    public override void Effect()
    {
        Encounter.playerActions = Encounter.playerActions + 2; //add two actions
        //allow player to choose a card to discard
    }
}
