using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class duckAttack : MonoBehaviour
{
    Animator duck;
    public static Action isHit;
    
    // Start is called before the first frame update
    void Start()
    {
        duck = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        

        if (collision.gameObject.tag == "Hammer")
        {
            Debug.Log("Źle");
            duckDestroy(duck);
        }
    }
    protected void duckDestroy(Animator duck)
    {
        duck.SetTrigger("Hit");
        Destroy(this.gameObject, 0.3f);
    }
}
