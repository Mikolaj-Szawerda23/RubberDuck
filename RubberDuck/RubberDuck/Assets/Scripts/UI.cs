using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI numberOfDucks;
    [SerializeField]
    TextMeshProUGUI score;
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
        Debug.Log(n.ToString());
        numberOfDucks.text ="Ducks:"+ n + "/" + toHit;
        score.text ="Score:"+ scoreNum.ToString();
    }
    
    private void OnDisable()
    {
        duckAttack.isHit -= updateText;
    }
}
