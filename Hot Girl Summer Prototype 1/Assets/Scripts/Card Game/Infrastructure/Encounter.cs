using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounter
{
    //Static elements in an encounter
    public static  Deck playerDeck;
    public static  Discard playerDiscard;
    public static  Hand playerHand;
    public static bool _isItPlayerTurn;
    private static NPC _npc;
    public static GameObject cardGUI;
    public static FiniteStateMachine<Encounter> cardGameFSM;

    //Constants for managing Hand GUI
    public const float beginningOfHand = -200;
    public const float endOfHand = 200;
    public const float handYPosition = -120;

    //Remaining actions in a player turn
    public static int playerActions;

    public Encounter(NPC npc)
    {
        playerDeck = new Deck();
        playerDiscard = new Discard();
        playerHand = new Hand();
        Debug.Log("Created Hand, deck, discard");
        _npc = npc;
        cardGUI = GameObject.FindGameObjectWithTag("HandZone");
        cardGameFSM = new FiniteStateMachine<Encounter>(this);
        cardGameFSM.TransitionTo<PlayerTurn>();
        Debug.Log("Transitioned to playerturn");

    }

    public void Play(Card cardToPlay)
    {
        cardToPlay.Effect();
        UpdateHandSize();
    }

    public void ChangeTurn()
    {
        if (_isItPlayerTurn) cardGameFSM.TransitionTo<NPCTurn>();
        else cardGameFSM.TransitionTo<PlayerTurn>();
    }

    public void OpponentEffect()
    {
        _npc.Effect();
        UpdateHandSize();
        UpdateCardGameObjects();
    }

    //Called after changes to hand to make sure display represents actual cards in Hand
    public void UpdateHandSize()
    {

        //float handIncrement = (endOfHand - beginningOfHand) / (playerHand.handTransforms.Count + 1);
        //float xPosition = 0;
        /*
        foreach (RectTransform cardInHand in playerHand.handTransforms)
        {
            xPosition += handIncrement;
            cardInHand.SetPositionAndRotation(new Vector3(beginningOfHand + xPosition, handYPosition, 0), Quaternion.identity);
        }

    */
    }

    public void UpdateCardGameObjects()
    {
        /*
        for (int i = 0; i < playerHand.cardsInHand.Count; i++)
        {
            playerHand.cardsInHand[i].cardOnScreen.cardDisplay.transform.SetPositionAndRotation(playerHand.handTransforms[i].position, Quaternion.identity);
        } */
    }

    public class PlayerTurn : FiniteStateMachine<Encounter>.State
    {
        public override void OnEnter()
        {
            Encounter._isItPlayerTurn = true;
            Encounter.playerActions = 1;
            playerDeck.Draw();
            playerDeck.Draw();
            playerDeck.Draw();

            foreach (Card card in Encounter.playerHand.cardsInHand)
            {
            }
        }

        public override void OnExit()
        {
            foreach (Card card in Encounter.playerHand.cardsInHand)
            {
            }
        }

        public override void Update()
        {
            base.Update();
        }

        
    }

    public class NPCTurn : FiniteStateMachine<Encounter>.State
    {
        public override void OnEnter()
        {
            Encounter._isItPlayerTurn = false;
            Services.encounter.OpponentEffect();
            Services.encounter.ChangeTurn();
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

    public class WaitForInput : FiniteStateMachine<Encounter>.State
    {
        public delegate void CheckingForInput();
        public static CheckingForInput whatAmIWaitingFor;
        public override void OnEnter()
        {
            //Services.eventManager.Register<conditionToAdvance>(Encounter.cardGameFSM.StopWaitingForInput);
        }

        public override void OnExit()
        {
            foreach (Card card in Encounter.playerHand.cardsInHand)
            {
            }
        }

        public override void Update()
        {
            //ExecuteDelegateFunction(whatAmIWaitingFor);
            whatAmIWaitingFor();
        }

        //UNUSED for time being 
        #region
        public static void StopWaitingForInput(HotGirlEvent e)
        {
            cardGameFSM.TransitionTo<PlayerTurn>();
        }

        public void ExecuteDelegateFunction(CheckingForInput function)
        {
            function();
        }
        #endregion
    }
}
