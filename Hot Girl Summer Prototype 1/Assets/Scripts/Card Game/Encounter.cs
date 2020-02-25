using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    private Deck _playerDeck;
    private Discard _playerDiscard;
    private Hand _playerHand;
    private bool _isItPlayerTurn;
    private NPC _npc;

    public int playerActions;

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
