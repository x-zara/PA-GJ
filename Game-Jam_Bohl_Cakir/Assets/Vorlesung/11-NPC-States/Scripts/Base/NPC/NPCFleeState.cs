using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NPCFleeState : BaseState
{
    public float fleeDistance;
    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCFleeState:Update");
    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCFleeState:Update");
    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCFleeState:Update");
    }
}
