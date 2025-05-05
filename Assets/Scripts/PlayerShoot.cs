using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public float timeToShoot = 0.4f;
    public GameObject projectile;

    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeToShoot && Input.GetMouseButton(0)) 
        {
            Quaternion rot = Quaternion.Euler(0, 0, 90);
            Instantiate(projectile, transform.position, rot);
            currentTime = 0;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

}
