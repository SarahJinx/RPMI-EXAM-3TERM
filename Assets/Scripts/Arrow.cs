using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile
{
    public Arrow(Sprite sprite)
    {
        this.damage = 25;
        this.speed = 30;
    }
    public override void Move()
    {
        Vector3 vector3 = new Vector3(0, 1 * speed, 0);
        _rb.velocity = vector3;
    }
}