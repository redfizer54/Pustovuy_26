using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {   if (collision.tag != "Player") 
            return;
        if(collision.tag != transform.tag) 
            Debug.Log("dead");
    }
}
