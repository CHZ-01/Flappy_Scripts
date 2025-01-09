using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCode : MonoBehaviour
{
    public Rigidbody2D gravity;
    public float jump;
    public restart over;
    public bool birdalive = true;
    public AudioSource Song;

    // Start is called before the first frame update
    void Start()
    {
        Song.Play();
        over = GameObject.FindGameObjectWithTag("over").GetComponent<restart>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdalive) 
        {
            gravity.velocity = Vector2.up * jump;
        }
        if(transform.position.y > 15 || transform.position.y < -15)
        {
            over.Gameover();
            birdalive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        over.Gameover();
        Song.Pause();
        birdalive = false;
    }
}
