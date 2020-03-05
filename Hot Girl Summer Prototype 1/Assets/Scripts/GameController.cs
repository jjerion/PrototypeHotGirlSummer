using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    /********************************************************************************************

        This GameController is a Monobehaviour that should be present in all scenes in the game.
        It is in charge of maintaining global variables and the overall state of the game.
        It has a DontDestroyOnLoad command so that it can stay constant between scenes.

    ********************************************************************************************/

    // This is the game's Finite State Machine, which keeps track of which phase you are in. You can
    // see what the phases for the game are towards the bottom of this file. For now,
    // the only phases that matter are the CardGame phase and the Story phase, which it will 
    // switch between when playing cards and talking to characters, respectively. 
    private static FiniteStateMachine<GameController> _gameFSM;

    
    //This is the Party Deck, which is a list of all the cards the player owns. This is different from
    // the Deck object in an Encounter, because the Party Deck includes the discard pile.
    public static DeckList partyDeck;

    
    //This is the next NPC that the player will have a card Encounter with. For now, this should only be Kelly,
    // but in the future, when the player finishes one Encounter, the next NPC will be queued up.
    public static NPC nextNPC;

    // This is called even before the Start function. I just wanted to perform the DontDestroyOnLoad
    // as early as possible.
    private void Awake()
    {
        Object.DontDestroyOnLoad(this);
    }

    
    // Here is where important public variables should be initialized. Be careful if you are testing
    // individual scenes without running the game from the beginning; since the GameController normall 
    //stays constant between scenes, you may need to write a special case to make sure the scene gets
    //initialized properly.

    void Start()
    {
        //The Services class is just a static class that acts as a list of all the major systems in the game.
        //Right now, Services has three attributes: the gameController (this), the eventManager, and the
        // encounter. 
        Services.GC = this;
        Services.eventManager = new EventManager();

        
        
        //These lines initialize the public attributes in the GameController
        partyDeck = new DeckList();
        nextNPC = new Kelly();
        _gameFSM = new FiniteStateMachine<GameController>(this);


        
        //PURELY FOR TESTING THE CARD ENCOUNTER SCENE. In the real game, we don't want to start playing
        // cards right away. Feel free to uncomment if you want to test the card game, but be mindful.
        #region
        /*
        partyDeck.AddCard(new Bubbly()); 
        partyDeck.AddCard(new GetPumped());             These lines add basic cards to the deck
        partyDeck.AddCard(new Dance());


        Debug.Log("Added cards");


        _gameFSM = new FiniteStateMachine<GameController>(this); This line creates a state machine for 
        _gameFSM.TransitionTo<CardGame>();
        Debug.Log("transitioned to card game");
        */
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        //We call the Finite State Machines' updates because we want the game to do different things
        // each frame depending on the game state.

        
        //The Game Controller updates first
        _gameFSM.Update();

        
        //Then the card Game Updates
        Encounter.cardGameFSM.Update();
    }
}
// This is where the States for the Game Controller Finite State Machine are.
#region
//The state of the game during a Card Game. You shouldn't have to edit any of this.
//The important thing is that an Encounter is created when you enter this state.
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

//The state of the game when you are just talking to party guests. You also shouldn't have to edit this.
public class Story : FiniteStateMachine<GameController>.State
{
    public override void OnEnter()
    {
        base.OnEnter();
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

#endregion
