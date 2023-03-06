using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour
{
    public Transform[] waypoints;
    public bool moveAllowed = false;
    public bool Clicked = false;

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
            Move();
        }
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            moveAllowed = true;
        }
    }

    private void OnMouseDown()
    {
        Clicked = true;
    }
    private void OnMouseUp()
    {
        Clicked = false;
    }
}
