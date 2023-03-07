using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour
{
    public Transform[] waypoints;
    public bool moveAllowed = false;
    public bool Clicked = false; //literally does nothing but removing it will be too much work so whatever
    public bool ReachedGoal = false;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    private void Start()
    {
        transform.position = waypoints[waypointIndex].position;
    }

    private void Update()
    {
        if (moveAllowed == true)
        {
            if (waypointIndex > 50)
            {
                waypointIndex = 50;
            }
            Move();
            if (waypointIndex == 50)
            {
                ReachedGoal = true;
            }
        }
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            moveAllowed = false;
        }
    }
}