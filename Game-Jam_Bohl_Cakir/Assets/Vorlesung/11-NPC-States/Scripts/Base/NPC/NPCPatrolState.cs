using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class NPCPatrolState : BaseState
{
    public Transform[] wayPoints;

    private int _currentWayPointIndex;

    private Vector3 _targetPosition;
    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:Update");

        var npcStateMachine = controller as NPCStateMachine;
        
        
        
        if(_targetPosition == Vector3.zero)
        {
            _targetPosition = wayPoints[0].position;
        }

        npcStateMachine.SetDestination(_targetPosition);
    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:Update");


        var npcStateMachine = controller as NPCStateMachine;

        float sqrtDistance = (npcStateMachine.transform.position - _targetPosition).sqrMagnitude;
        if( sqrtDistance > 0.1 )
        {
            _targetPosition = GetNextWaypoint();
            npcStateMachine.SwitchToState(npcStateMachine.idleState);
        }
    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:Update");
    }

    public Vector3 GetNextWaypoint()
    {
        _currentWayPointIndex = ++_currentWayPointIndex % wayPoints.Length;
        return wayPoints[_currentWayPointIndex].position;
    }
}
