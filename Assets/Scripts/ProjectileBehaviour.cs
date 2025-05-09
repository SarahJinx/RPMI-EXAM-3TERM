using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float aliveTime = 5;
  
    private float currentTime = 0;

    private Projectile Projectile;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > aliveTime) 
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.GetComponent<Enemy>())
        {
            Projectile.Hit(enemy);
        }
    }
}
