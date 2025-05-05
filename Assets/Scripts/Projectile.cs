using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Projectile
{
    protected float speed;
    protected float damage;
    protected Rigidbody2D _rb;
    private Sprite sprite;


    public Projectile() { }
    public Projectile(float speed, float damage, Rigidbody2D _rb, Sprite sprite)
    {
        this.speed = speed;
        this.damage = damage;
        this._rb = _rb;
        this.sprite = sprite;
    }

    protected Projectile(int v1, int v2, Sprite sprite)
    {
        this.sprite = sprite;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }
    public abstract void Move();
    public virtual GameObject Hit(GameObject reciever)
    {
        return reciever;
    }
}

