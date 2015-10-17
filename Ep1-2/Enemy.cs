using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour {

    NavMeshAgent pathfinder;
    Transform target;

	// Use this for initialization
	void Start () {

        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator UpdatePath() {

        float refreshRate = .25f;

        while (target != null) {
            Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z);
            pathfinder.SetDestination(targetPosition);

            yield return new WaitForSeconds(refreshRate);
        }

    }
}
