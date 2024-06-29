using UnityEngine;
using UnityEngine.AI;

public enum NPCState { Idle, Flee, Patrol }

/// <summary>
/// Einfache Implementierung eines NPC mit zwei Zust�nden (Idle + Flee)
/// unter Verwendung von Enumerationstypen
/// </summary>
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class NPC : MonoBehaviour
{
    // In welchem Zustand startet der NPC
    public NPCState StartState;       

    // Distanz ab welcher der NPC fl�chtet
    public float ComfortDistance;

    // Distanz die der NPC wegrennt
    public float RunAwayDistance;

    // Aktueller Zustand (Idle/Flee)
    public NPCState CurrentState { get; private set; }

    public Transform[] wayPoints;

    // Referenz zum Spieler
    private Transform _player;

    // Animation
    private Animator _animator;
    private int _speedParameterHash;

    // NavMesh Agent
    private NavMeshAgent _agent;

    private bool hasReached;

    // Start is called before the first frame update
    void Start()
    {
        CurrentState = StartState;

        _player = GameObject.FindGameObjectWithTag("Player").transform;

        _animator = GetComponent<Animator>();
        _speedParameterHash = Animator.StringToHash("speed");

        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentState) 
        {
            case NPCState.Idle:
                
                Idle();
                // �berg�nge (Transitions)
                if(Vector3.Distance(transform.position, _player.position) < ComfortDistance)
                {
                    CurrentState = NPCState.Flee;
                }
                break;
                
            case NPCState.Flee:
                Flee();
                // �berg�nge (Transitions)
                if (Vector3.Distance(transform.position, _player.position) > RunAwayDistance)
                {
                    CurrentState = NPCState.Idle;
                }
                break;
                /*
            case NPCState.Patrol:
                Patrol();
                if (Vector3.Distance(transform.position, wayPoints[2].position) == 0)
                {
                    CurrentState = NPCState.Idle;
                }
                break;
                */
        }
    }

    /// <summary>
    /// Logik die jedes Frame im Idle-Zustand ausgef�hrt wird
    /// </summary>
    private void Idle()
    {
        _animator.SetFloat(_speedParameterHash, 0);
        _agent.destination = transform.position;
    }

    /// <summary>
    /// Logik die jedes Frame im Flee-Zustand ausgef�hrt wird
    /// </summary>
    private void Flee() 
    {
        _animator.SetFloat(_speedParameterHash, _agent.velocity.magnitude);
        _agent.destination = (transform.position - _player.position).normalized * RunAwayDistance;
    }

    private void Patrol()
    {
        _animator.SetFloat(_speedParameterHash, _agent.velocity.magnitude);
        _agent.destination = wayPoints[0].position;

        hasReached = true;

    }
}
