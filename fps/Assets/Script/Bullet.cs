using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public  float moveSpeed = 10f;
    public float lifeTime = 5f;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
     _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = transform.forward * moveSpeed;

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("targetstand"))
       {
        Debug.Log("hit the standing target ");

        //add to scoreboard
        //grey out standing target
       } 

       if(other.gameObject.CompareTag("targetfloat"))
    {
        Debug.Log("hit the floating target");
        //add to scoreboard 
    
    }
    }
}
