using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class GameManager : MonoBehaviour
    {
        public ScoreManager manager;
        public GameOverScreen gameoverscreen;
        int maxScores = 0;
        public void GameOver()
        {
            gameoverscreen.Setup(maxScores);
        }
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



                if (ray.collider.gameObject.CompareTag("Ants"))

                {
                    manager.PlayerkilledScore(1);
                    Destroy(ray.collider.gameObject);
                }
                if (ray.collider.gameObject.CompareTag("GoodAnts"))
                 {
                    manager.PlayerlivesScore(-10);
                    Destroy(ray.collider.gameObject);
                    

                }
            }
        }
    }
}