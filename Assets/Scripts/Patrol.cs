using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    public Transform[] waypoints; // Array to hold waypoints
    public float speed = 2.0f;    // Speed of the patrol
    private int currentWaypointIndex = 0; // Current waypoint index

    void Update()
    {
        PatrolCycle();
    }

    void PatrolCycle()
    {
        // Move towards the current waypoint
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;

        // Move the NPC
        transform.position += direction * speed * Time.deltaTime;

        // Check if the NPC has reached the current waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            // Update the current waypoint index to the next one
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Loop back to the first waypoint
        }
    }
}
