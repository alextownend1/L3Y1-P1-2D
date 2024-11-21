using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FlyingEnemy : MonoBehaviour
{

    public int damage;
    public float moveSpeed;
    public float distance;
    Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Vector2.Distance(transform.position, target.position);

        if (currentDistance < distance)
       {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
       } 
    }
}
