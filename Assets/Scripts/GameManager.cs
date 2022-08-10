using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreManager manager;
private void Update()
    {
        playerInput();
        
    }

    void playerInput()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }
    private void CastRay()
    {
        RaycastHit2D ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (ray)
        {
            Collider2D[] hitColliders = Physics2D.OverlapBoxAll(ray.point, new Vector2(100, 100), 0f);
            

                if (ray.collider.gameObject.tag == "Ants")

                {
                manager.PlayerkilledScore(1);
                Destroy(ray.collider.gameObject);
                }
                else
            {
                manager.PlayerlivesScore(-1);
            }
        }
    }
}
