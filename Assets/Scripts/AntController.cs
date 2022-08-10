using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntController : MonoBehaviour
{


    float x;
    float y;
    public Vector2 speed;
    Vector2 pos;
    private Rigidbody2D rb;
    public ScoreManager manager;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        x = Random.Range(-9, 9);
        y = Random.Range(5, 9);
        
        pos = new Vector2(x, y);
        transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {  
        transform.Translate(speed * Time.deltaTime);
    }

    
    void OnMouseDown()
    {   
        Destroy(gameObject);
        manager.PlayerkilledScore(1);     
    }
}
