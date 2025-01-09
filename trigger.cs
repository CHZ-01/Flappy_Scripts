using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public score_manager score; 

    // Start is called before the first frame update
    void Start()
    {
        score= GameObject.FindGameObjectWithTag("score").GetComponent<score_manager>();
    }

    //score trigger check
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score.addscore(1);// adding score function
        }
    }

}
