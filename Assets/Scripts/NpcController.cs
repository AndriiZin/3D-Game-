using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : Interaction
{
    protected override void Interact()
    {
        base.Interact();
        Debug.Log("Npc: ĳ����.");
    }
}