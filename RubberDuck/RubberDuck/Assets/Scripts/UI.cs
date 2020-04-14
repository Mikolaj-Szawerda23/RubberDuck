using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    [SerializeField]
    Text numberOfDucks;
    [SerializeField]
    Text score;
    int n = 0,toHit,scoreNum=0;
    // Start is called before the first frame update
    void Start()
    {
        duckAttack.isHit += updateText;
        toHit = gameMan.numberOfDuckToHit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void updateText()
    {
        scoreNum += 100;
        n = gameMan.hitsDuck;
        string text = n + "/"+toHit;
        numberOfDucks.text = text;
        score.text ="Score:"+ scoreNum.ToString();
    }
    
    private void OnDisable()
    {
        duckAttack.isHit -= updateText;
    }
}
