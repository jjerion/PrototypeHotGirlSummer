using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardGUIEvents : EventTrigger
{

    private Transform startingPosition;
    public static Rect playableCardZone;
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

    public override void OnDrag(PointerEventData pointerEvent)
    {
        startingPosition = gameObject.transform;
        Debug.Log("Dragging card");
        gameObject.transform.SetPositionAndRotation(pointerEvent.position, Quaternion.identity);

    }

    public override void OnDrop(PointerEventData pointerEvent)
    {
        Debug.Log("No longer dragging");
        if (playableCardZone.Contains(pointerEvent.position) && GetComponent<CardIdentifier>().whichCardIsThis.displayedInfo.isPlayable)
        {
            Encounter.playerHand.PlayFromHand(GetComponent<CardIdentifier>().whichCardIsThis);
        }
        else
        {
            gameObject.transform.SetPositionAndRotation(startingPosition.position, Quaternion.identity);
        }
    }
}
