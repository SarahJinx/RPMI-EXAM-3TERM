using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomerang : Projectile
{
    private float timeToReturn;
    public Boomerang(Sprite sprite, float timeToReturn)
    {
        this.damage = 8;
        this.speed = 10;
        this.timeToReturn = timeToReturn;
    }
    //private Rigidbody2D GetRigidbody2D()
    //{
    //    return _rb;
    //}
    public override void Move() 
    {
        timeToReturn -= Time.deltaTime;
        if (timeToReturn <= 0)
        {
            speed *= -1;
        }
        Vector3 vector3 = new Vector3(0, 1 * speed, 0); 
        _rb.velocity = vector3;
    }
}
