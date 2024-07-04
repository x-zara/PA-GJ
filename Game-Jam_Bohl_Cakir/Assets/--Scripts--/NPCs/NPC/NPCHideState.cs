using System;
using UnityEngine;

[Serializable]
public class NPCHideState : BaseState
{
    public Transform[] HidingSpots;

    private Vector3 targetPosition;

    private Transform _playerTransform;
    
    public override void OnEnterState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:OnEnterState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;
        
        // follow player
        _playerTransform = GameObject.Find("Player").transform;
        npcStateMachine.SetDestination(_playerTransform.position);
        npcStateMachine.SetAgentSpeedMultiplier(1.5f);

    }

    public override void OnUpdateState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:OnUpdateState");

        NPCStateMachine npcStateMachine = controller as NPCStateMachine;
        npcStateMachine.SetDestination(_playerTransform.position);
        npcStateMachine.SetAgentSpeedMultiplier(1.5f);
        // Transitions
        // NPC reached waypoint? > Switch to idle
        //float sqrtDistance = (npcStateMachine.transform.position - targetPosition).sqrMagnitude;
        //Debug.Log("dist: " + sqrtDistance);

        /*if (sqrtDistance < 3f) 
        {
            npcStateMachine.SwitchToState(npcStateMachine.IdleState);
        }*/
    }

    public override void OnExitState(BaseStateMachine controller)
    {
        Debug.Log("NPCPatrolState:OnExitState");
        NPCStateMachine npcStateMachine = controller as NPCStateMachine;

        npcStateMachine.SetAgentSpeedMultiplier(1f);
    }

    public Vector3 GetNearestHidingSpot(Vector3 position) 
    {
        if (HidingSpots.Length < 2)
            return Vector3.zero;

        int shortestSqrtDistanceIndex = 0;
        float shortestSqrtDistance = (HidingSpots[0].position - position).sqrMagnitude;
        for (int i = 1; i < HidingSpots.Length; i++)
        {
            float sqrtDistance = (HidingSpots[i].position - position).sqrMagnitude;
            if (sqrtDistance < shortestSqrtDistance)
            {
                shortestSqrtDistance = sqrtDistance;
                shortestSqrtDistanceIndex = i;
            }
        }
        
        return HidingSpots[shortestSqrtDistanceIndex].position;
    }
}
