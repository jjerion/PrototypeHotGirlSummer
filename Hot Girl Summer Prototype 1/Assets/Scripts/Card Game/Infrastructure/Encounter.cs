using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    //Static elements in an encounter
    public static readonly Deck playerDeck;
    public static readonly Discard playerDiscard;
    public static readonly Hand playerHand;
    public static bool _isItPlayerTurn;
    private static NPC _npc;
    public static Canvas cardGUI;
    public static FiniteStateMachine<Encounter> cardGameFSM;

    //Constants for managing Hand GUI
    public const float beginningOfHand = -200;
    public const float endOfHand = 200;
    public const float handYPosition = -120;

    //Remaining actions in a player turn
    public static int playerActions;

    public void Play(Card cardToPlay)
    {
        cardToPlay.Effect();
        UpdateHandSize();
    }

    public void ChangeTurn()
    {

    }

    public void OpponentEffect()
    {
        _npc.Effect();
        UpdateHandSize();
    }

    //Called after changes to hand to make sure display represents actual cards in Hand
    public void UpdateHandSize()
    {

        float handIncrement = (endOfHand - beginningOfHand) / (playerHand.handTransforms.Count + 1);
        float xPosition = 0;
        foreach (RectTransform cardInHand in playerHand.handTransforms)
        {
            xPosition += handIncrement;
            cardInHand.SetPositionAndRotation(new Vector3(beginningOfHand + xPosition, handYPosition, 0), Quaternion.identity);
        }


    }

    public void UpdateCardGameObjects()
    {
        for (int i = 0; i < playerHand.cardsInHand.Count; i++)
        {
            playerHand.cardsInHand[i].cardOnScreen.cardDisplay.transform.SetPositionAndRotation(playerHand.handTransforms[i].position, Quaternion.identity);
        }
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
