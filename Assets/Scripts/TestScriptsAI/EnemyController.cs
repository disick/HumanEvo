using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    private enum State
    {
        Patrol,
        Chase
    };

    private const float PATROL_RADIUS = 5;
    private const float CHASE_RADIUS = 10;

    private State currentState = State.Patrol;

    private NavMeshAgent agent;

    private Collider col;

    [SerializeField]
    private Transform target;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        col = GetComponent<Collider>();
    }

    public void Update()
    {

        Vector3 targetPos = target.position;
        Vector3 ownPos = transform.position;

        State newState = currentState;

        // choose state transition, if needed...
        if (currentState == State.Patrol)
        {
            float d = Vector3.Distance(targetPos, ownPos);
            if (d < PATROL_RADIUS)
            {
                newState = State.Chase;
                Debug.LogFormat("[{0}] Choosing transition to {1} state...", gameObject.name, newState);
            }
        }
        else if (currentState == State.Chase)
        {
            float d = Vector3.Distance(targetPos, ownPos);
            if (d > CHASE_RADIUS)
            {
                newState = State.Patrol;
                Debug.LogFormat("[{0}] Choosing transition to {1} state...", gameObject.name, newState);
            }
        }

        // handle state transition, if needed...
        if (newState != currentState)
        {

            // handle exit from current state...
            Debug.LogFormat("[{0}] Exiting from {1} state...", gameObject.name, currentState);
            switch (currentState)
            {
                case State.Patrol:
                    // TODO: exit from patrol state...
                    break;
                case State.Chase:
                    // exit from chase state...
                    agent.velocity = Vector3.zero;
                    agent.ResetPath();
                    break;
            }

            // make the transition...
            Debug.LogFormat("[{0}] Making transition to {1} state...", gameObject.name, newState);
            currentState = newState;

            // handle entry to new state...
            Debug.LogFormat("[{0}] Entering {1} state...", gameObject.name, newState);
            switch (currentState)
            {
                case State.Patrol:
                    // entry to patrol state...
                    break;
                case State.Chase:
                    // entry to chase state...
                    break;
            }
        }

        // run current state...
        switch (currentState)
        {
            case State.Patrol:
                // TODO: patrol...
                break;
            case State.Chase:
                agent.SetDestination(targetPos);
                break;
        }
    }

    public void OnDrawGizmos()
    {
        switch (currentState)
        {
            case State.Patrol:
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(transform.position, PATROL_RADIUS);
                break;
            case State.Chase:
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, CHASE_RADIUS);
                break;
        }
    }
}
