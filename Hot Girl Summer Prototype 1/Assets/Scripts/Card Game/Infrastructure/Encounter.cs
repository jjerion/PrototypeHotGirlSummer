using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    public static readonly Deck playerDeck;
    public static readonly Discard playerDiscard;
    public static readonly Hand playerHand;
    public static bool _isItPlayerTurn;
    private static NPC _npc;
    public static Canvas cardGUI;
    public static FiniteStateMachine<Encounter> cardGameFSM;

    public static int playerActions;

    public void Play(Card cardToPlay)
    {
        cardToPlay.Effect();
        OrganizeCards();
    }

    public void ChangeTurn()
    {

    }

    public void OpponentEffect()
    {
        _npc.Effect();
        OrganizeCards();
    }

    //Called after changes to hand to make sure display represents actual cards in Hand
    public void OrganizeCards()
    {

    }

    public class PlayerTurn : FiniteStateMachine<Encounter>.State
    {

    }

    public class NPCTurn : FiniteStateMachine<Encounter>.State
    {

    }

    public class WaitForInput : FiniteStateMachine<Encounter>.State
    {

    }
}
