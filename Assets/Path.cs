using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Path : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;
    
    

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    [Header("Unity Stuff")]
    public Image HealthBar;
    public float health = 1f;

    public int worth = 100;
    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

   

    // Use this for initialization
    private void Start()
    {

        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if(HealthBar.fillAmount==0)
        {
            Destroy(this.gameObject);
        }
        // Move Enemy
        Move();
    }

/*    private void MoveUp()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointUpIndex <= waypointsUP.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypointsUP[waypointUpIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypointsUP[waypointUpIndex].transform.position)
            {
                waypointUpIndex += 1;
            }
        }
    }*/

    //public void takeDame(float amount)
    //{
    //    health -= amount;
    //    Debug.Log("health: "+health);
    //    HealthBar.fillAmount = health;
    //    if(health <= 0)
    //    {
    //        Die();
    //    }

    //}

    //private void Die()
    //{
    //    //DestroyObject(this);
    //}

    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
