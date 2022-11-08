using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform wayPoint01, wayPoint02;
    private Transform wayPointTarget;
    [SerializeField] private float moveSpeed;
    private float direction = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        wayPointTarget = wayPoint02;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPointTarget.position, moveSpeed*Time.deltaTime);

        if(Vector2.Distance(transform.position, wayPoint01.position)<= 0.1f)
        {
            wayPointTarget = wayPoint02;
            direction = 0.5f;
            transform.localScale = new Vector3(direction, 0.5f, 0.5f);
        }

        if(Vector2.Distance(transform.position, wayPoint02.position)<= 0.1f)
        {
            wayPointTarget = wayPoint01;
            direction = -0.5f;
            transform.localScale = new Vector3(direction, 0.5f, 0.5f);
        }

    }
}
