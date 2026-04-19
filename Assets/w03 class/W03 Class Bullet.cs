using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W03ClassBullet : MonoBehaviour
{
    [Header("Effects")]
    public GameObject ShootParticle, HitParticle, MissParticle;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject shootParticle = Instantiate(ShootParticle, transform.position, transform.rotation);
        Destroy(shootParticle, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {


            GameObject hitEffect = Instantiate(HitParticle, transform.position, transform.rotation);
            Destroy(hitEffect, 2f);
            print("Hit");
        }
        else
        {
            GameObject missEffect = Instantiate(MissParticle, transform.position, transform.rotation);
            Destroy(missEffect, 2f);
            print("Miss");
        }
        //Destroy(gameObject);

    }
}
