using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArrow : Projectile
{
    public float freq; // Velocidad de la oscilación
    public float amp = 1;
    private float slowDownEffect;
    public Transform movement;
    public GameObject enemyObject;

    public IceArrow(Sprite sprite, float slowDownEffect)
    {
        this.damage = 10;
        this.speed = 15;
        this.slowDownEffect = 0.5f;
    }
    public override void Move()
    {
        freq = speed * 2;

        float sinVal = Mathf.Sin(Time.time * freq); 
        Vector3 vector3 = new Vector3(sinVal * amp, speed, 0);
        _rb.velocity = vector3;
    }

    public override void Hit(GameObject iceArrow)
    {
        
    }
}