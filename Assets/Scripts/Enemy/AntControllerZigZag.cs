using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class AntControllerZigZag : BaseCharacter
    {
       

        void Start()
        {
            //pos = transform.position;
            axis = transform.right;


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
           
            pos += Vector2.down * Time.deltaTime * _cycleSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * _frequency) * _amplitude;
            rb.velocity = Vector2.down * speed;
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