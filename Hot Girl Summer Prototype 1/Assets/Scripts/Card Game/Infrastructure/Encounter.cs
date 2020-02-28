using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    public static readonly Deck playerDeck;
    public static readonly Discard playerDiscard;
    public static readonly Hand playerHand;
    public bool _isItPlayerTurn;
    private static NPC _npc;
    public static FiniteStateMachine<Encounter> cardGameFSM;

    public static int playerActions;

    private void Play(Card cardToPlay)
    {
        cardToPlay.Effect();
    }

    public void ChangeTurn()
    {

    }

    public void OpponentEffect()
    {
        _npc.Effect();
    }
}
