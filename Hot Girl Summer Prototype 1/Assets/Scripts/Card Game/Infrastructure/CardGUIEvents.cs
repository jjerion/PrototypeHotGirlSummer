using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardGUIEvents : EventTrigger
{

    private Transform startingPosition;
    public static Rect playableCardZone;
    public static Card cardSelectedByPlayer;
    // Start is called before the first frame update
    void Start()
    {
        playableCardZone = GameObject.Find("PlayableCardZone").GetComponent<RectTransform>().rect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerEnter(PointerEventData pointerEvent)
    {
        Debug.Log("Hovering over card");
    }

    public override void OnPointerExit(PointerEventData pointerEvent)
    {
        Debug.Log("No longer hovering");
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        startingPosition = gameObject.transform;
    }
    public override void OnDrag(PointerEventData pointerEvent)
    {

        Debug.Log("Dragging card");
        gameObject.transform.SetPositionAndRotation(pointerEvent.position, Quaternion.identity);

    }


    public override void OnEndDrag(PointerEventData pointerEvent)
    {
        Debug.Log("No longer dragging");
        Debug.Log(playableCardZone);
        if (Encounter.cardGameFSM.CurrentState.GetType() == typeof(Encounter.PlayerTurn))
        {
            Debug.Log(gameObject.transform.localPosition);
            Debug.Assert(playableCardZone.Contains(gameObject.transform.localPosition), "Assertion failed: Rect contains GameObject");
            Debug.Assert(GetComponent<CardIdentifier>().whichCardIsThis.displayedInfo.isPlayable, "Assertion failed: Card is playable");
            if (playableCardZone.Contains(gameObject.transform.localPosition) && GetComponent<CardIdentifier>().whichCardIsThis.displayedInfo.isPlayable)
            {
                Debug.Log("I'm gonna play a card");
                Encounter.playerHand.PlayFromHand(GetComponent<CardIdentifier>().whichCardIsThis);
            }
            else
            {
                gameObject.transform.SetPositionAndRotation(startingPosition.position, Quaternion.identity);
            }
        }
        else if (Encounter.cardGameFSM.CurrentState.GetType() == typeof(Encounter.WaitForInput))
        {
            if (playableCardZone.Contains(gameObject.transform.localPosition))
            {
                cardSelectedByPlayer = GetComponent<CardIdentifier>().whichCardIsThis;
            }
            else
            {
                gameObject.transform.SetPositionAndRotation(startingPosition.position, Quaternion.identity);
            }
        }
    }
}
