using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    
    [SerializeField]protected float speed;
    protected float x;
    protected float y;
    protected Vector2 pos;
    protected Rigidbody2D rb;
    protected Vector2 velocity;
    protected float _frequency = 1.0f;
    protected float _amplitude = 4.0f;
    protected float _cycleSpeed = 5.0f;
    //protected Vector2 posx;
    protected Vector2 axis;

    public abstract void Move();

   
    public abstract void Pos();
    //public virtual float Pos(float x, float y) { /* Method statements here */ return 1; }
    public abstract void OnDestroy();
    
}

