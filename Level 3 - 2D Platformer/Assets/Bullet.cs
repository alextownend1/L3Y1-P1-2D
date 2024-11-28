using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
        
    }    
    

    // Update is called once per frame
    void Update()
    {
         transform.gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * moveSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }


}
