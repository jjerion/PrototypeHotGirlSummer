using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static FiniteStateMachine<GameController> _gameFSM;
    public static DeckList partyDeck;
    public static NPC nextNPC;

    // Start is called before the first frame update
    void Start()
    {
        partyDeck = new DeckList();
        nextNPC = new Kelly();
        //Purely for testing card game
        partyDeck.AddCard(new Bubbly());
        partyDeck.AddCard(new GetPumped());
        partyDeck.AddCard(new Dance());
        Debug.Log("Added cards");
        _gameFSM = new FiniteStateMachine<GameController>(this);
        _gameFSM.TransitionTo<CardGame>();
        Debug.Log("transitioned to card game");
        
    }

    // Update is called once per frame
    void Update()
    {
        _gameFSM.Update();
        Encounter.cardGameFSM.Update();
    }
}

public class CardGame : FiniteStateMachine<GameController>.State
{
    public override void OnEnter()
    {
        Services.encounter = new Encounter(GameController.nextNPC);
    }

    public override void OnExit()
    {
        base.OnExit();
    }

    public override void Update()
    {
        base.Update();
    }
}
