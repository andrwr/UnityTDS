using UnityEngine;
using System.Collections;

[RequireComponent (typeof (NavMeshAgent))]
public class Enemy : MonoBehaviour {

    NavMeshAgent pathfinder;
    // Need to know where the player is so i can chase him.
    Transform target;

	void Start () {

        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

        StartCoroutine(UpdatePath());
    }
	
	

    IEnumerator UpdatePath() {
        float refreshRate = 0.25f;

        while (target != null) {
            Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z);

            pathfinder.SetDestination(targetPosition);

            yield return new WaitForSeconds(refreshRate);
        }
    }
}
