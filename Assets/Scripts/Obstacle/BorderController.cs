using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    public Collider2D ant;
    public ScoreManager manager;
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ants"))
        {
            manager.PlayermissedScore(1);
            Destroy(collision.gameObject);
            manager.PlayerlivesScore(-1);
        }
        
    }
}
