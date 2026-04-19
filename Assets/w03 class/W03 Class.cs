using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W03Class : MonoBehaviour
{
    public GameObject BulletPreFab;

    public Transform FirePoint;
    public float bulletspeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Shoot");
            Shoot();
            //ApplyRecoil();

        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(BulletPreFab,FirePoint.position,FirePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        { 
            rb.velocity = FirePoint.forward*bulletspeed;
        
        }
        Destroy(bullet, 3f);

    }
}
