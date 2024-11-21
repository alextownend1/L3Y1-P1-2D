using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float followSpeed;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offset = new Vector3(0,0,-10);
        transform.position = Vector3.Lerp(transform.position, target.position + offset, followSpeed * Time.deltaTime);
    }
}
