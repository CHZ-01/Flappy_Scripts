using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarCode : MonoBehaviour
{
    public float speed;
    public float destroy = -40;

    // Update is called once per frame
    void Update()
    {
        //pillar move
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;

        //pillar destroy
        if( transform.position.x < destroy )
        {
            Destroy(gameObject);//destroy passed objects
        }
    }
}
