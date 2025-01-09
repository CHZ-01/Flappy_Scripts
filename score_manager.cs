using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_manager : MonoBehaviour
{
    public int score;
    public Text scoretxt;

    [ContextMenu("add")]
    //add score function
    public void addscore(int scr)
    {
        score += scr;
        scoretxt.text = score.ToString();//ading score 
    }

}
