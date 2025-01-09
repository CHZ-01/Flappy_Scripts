using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{
    public GameObject pillar;
    public float rate = 2;
    public float time = 0;
    public float offset = 8;

    // Start is called before the first frame update
    void Start()
    {
        spawn();//spawn pillar
    }

    // Update is called once per frame
    void Update()
    {
        //spawn time creation
        if(time < rate)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawn();
            time = 0;
        }
    }

    //spawn function
    void spawn()
    {   
        //low position
        float low = transform.position.y - offset;

        //high positiom
        float high = transform.position.y + offset;
        
        //create pillar
        Instantiate(pillar, new Vector3(transform.position.x,Random.Range(low,high),0), transform.rotation);
    }
}
