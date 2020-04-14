using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badDuckAttack : duckAttack
{
    Animator duck;
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
            gameMan.hitsDuck++;
            isHit?.Invoke();
            duckDestroy(duck);
        }
           
    }
}
