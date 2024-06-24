using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NPCStateMachine : BaseStateMachine
{
    public Vector3 playerPosition { get => _playerTransform.position; }

    public bool CanSeePlayer { get=> _eyes.IsDetecting; }

    public bool CanHearPlayer { get => _eyes.IsDetecting; }
    
    public NPCIdleState idleState;
    
    public NPCPatrolState patrolState;

    public NPCFleeState fleeState;

    private Eyes _eyes;

    private Ears _ears;

    private Transform _playerTransform;

    private NavMeshAgent _agent;

    private Animator _animator;

    public override void Initialize()
    {
        _eyes = GetComponentInChildren<Eyes>();

        _ears = GetComponentInChildren<Ears>();

        _playerTransform = GameObject.Find("Player").transform;

        CurrentState = idleState;
        CurrentState.OnEnterState(this);

        _agent = GetComponent<NavMeshAgent>();

        _animator = GetComponent<Animator>();
    }

    public override void Tick()
    {
        _animator.SetFloat("speed", _agent.velocity.magnitude);
    }

    public void SetDestination(Vector3 destination)
    {
        _agent.SetDestination(destination);
    }

}
