using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kelly : NPC
{
    public Kelly()
    {
        npcName = "Kelly";
        npcSprite = null;
    }


    public override void Effect()
    {
        Debug.Log("Kelly Effect");
    }
}
