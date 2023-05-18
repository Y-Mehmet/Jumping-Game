using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerController pCScript;
    float score;
    Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        pCScript=GameObject.Find("Player").GetComponent<PlayerController>();
        playerAnimator=GameObject.Find("Player").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       if (!pCScript.isGameOver)
        {if( Input.GetKey(KeyCode.T) )
        {
            score+=Time.deltaTime*2;
            playerAnimator.SetFloat("SpeedM_f",2.0f);
        }
        else 
        {
            score+=Time.deltaTime;
            playerAnimator.SetFloat("SpeedM_f",1.0f);
        }

        Debug.Log("Score: "+score);}
    }
}
