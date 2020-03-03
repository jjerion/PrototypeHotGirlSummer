using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrivateTalk : Card

{
    public PrivateTalk()
    {
        displayedInfo.cardName = "Private Talk";
        displayedInfo.type = (int)Vibes.Calm;
        displayedInfo.value = 1;
        displayedInfo.isPlayable = true;
        displayedInfo.text = "Play your next action card twice. Add one Chill Victory Card to your discard.";
        displayedInfo.art = Resources.Load<Sprite>("");


    }
    public override void Effect()
    {
        var newCard = new Chill();
        Encounter.playerDiscard.AddToDiscard(newCard);
        //THOMAS PLS HELP ME ADD SOME CODE THAT ALLOWS YOU TO PLAY YOUR NEXT ACTION CARD TWICE.
        Debug.Log("played Private Talk");
    }
}
