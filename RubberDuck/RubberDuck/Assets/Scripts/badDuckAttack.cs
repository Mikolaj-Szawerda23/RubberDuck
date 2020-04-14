using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badDuckAttack : duckAttack
{
    Animator duck2;
    // Start is called before the first frame update
    void Start()
    {
        duck2 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hammer")
        {
            gameMan.hitsDuck+=1;
            isHit?.Invoke();
            duckDestroy(duck2);
        }
           
    }
}
