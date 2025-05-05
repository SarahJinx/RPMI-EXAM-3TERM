using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Projectile
{
    protected float speed;
    protected float damage;
    protected Rigidbody _rb;
    private Sprite sprite;

    public Projectile() { }
    public Projectile(float speed, float damage, Rigidbody _rb, Sprite sprite)
    {
        this.speed = speed;
        this.damage = damage;
        this._rb = _rb;
        this.sprite = sprite;
    }
    protected Projectile(Sprite sprite)
    {
        this.sprite = sprite;
    }
    public Sprite GetSprite()
    {
        return sprite;
    }
    public abstract void Move();
    public virtual void Hit(GameObject projectile)
    {
    }
}

