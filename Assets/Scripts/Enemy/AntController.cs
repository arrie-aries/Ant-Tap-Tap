using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class AntController : BaseCharacter
    {
        // Start is called before the first frame update
        void Start()
        {
            Pos();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
        }



        public override void OnDestroy()
        {
            Debug.Log("destroyed");

        }

        public override void Move()
        {
            rb.velocity = Vector2.down * speed;
            Debug.Log(rb.velocity);
        }

        public override void Pos()
        {
            rb = GetComponent<Rigidbody2D>();
            x = Random.Range(-9, 9);
            y = Random.Range(5, 9);

            pos = new Vector2(x, y);
            transform.position = pos;
        }
    }
}