using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed = 5.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    public void onCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemies"))
        {
            Debug.Log("Enemy ouch");
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Walls")
        {
           if(Input.GetKey(KeyCode.LeftArrow))
        {
           transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
           transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(0, speed * Time.deltaTime, 0);
        }
        }
    }
}
