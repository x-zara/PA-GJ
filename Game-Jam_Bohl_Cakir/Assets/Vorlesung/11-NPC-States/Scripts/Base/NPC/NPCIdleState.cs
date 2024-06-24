using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[Serializable]
public class NPCIdleState : BaseState
{

    public float MinWaitTime;

    public float MaxWaitTime;

    private float _leaveTime;


    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCIdleState:Update");

        _leaveTime = Time.time + UnityEngine.Random.Range(MinWaitTime, MaxWaitTime);
    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCIdleState:Update");
        var npcStateMachine = controller as NPCStateMachine;

        // Transitions
        // Can see or hear player > Switch to flee
        if(npcStateMachine.CanSeePlayer || npcStateMachine.CanHearPlayer)
        {
            npcStateMachine.SwitchToState(npcStateMachine.fleeState);
        }

        // Time is up > Switch to Patrol
        if(Time.time > _leaveTime)
        {
            npcStateMachine.SwitchToState(npcStateMachine.patrolState);
        }
   
    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCIdleState:Update");
    }
}
