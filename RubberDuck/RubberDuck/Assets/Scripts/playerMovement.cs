using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator playerAttack;
    void Start()
    {
        playerAttack = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
    public void buttonClick()
    {
        playerAttack.SetTrigger("Shoot");
    }
}
