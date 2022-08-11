using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class GameManager : MonoBehaviour
    {
       
        public ScoreManager manager;
        private void Update()
        {
            PlayerInput();

        }

         public void PlayerInput()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CastRay();
            }
        }
        public void CastRay()
        {
            RaycastHit2D ray = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (ray)
            {



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
}