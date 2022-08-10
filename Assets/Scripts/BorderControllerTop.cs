using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderControllerTop : MonoBehaviour
{
   // public Collider2D ant;
    public ScoreManager manager;
   


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ants"))
        {

            manager.PlayerwavesScore(1);
            Debug.Log("detected");

        }

    }
}
