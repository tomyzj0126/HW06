using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EXbulletEnhanced : MonoBehaviour
{
   
    public GameObject ShootParticle,HitParticle,MissParticle;
    EXScoreMannger scoreMannger;
    bool isHit = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,3f);
        GameObject shootParticle = Instantiate(ShootParticle, transform.position, transform.rotation);
        Destroy(shootParticle, 2f);

        scoreMannger = Object.FindObjectOfType<EXScoreMannger>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isHit) return;
        if (collision.gameObject.CompareTag("Target"))
        {


            GameObject hitEffect = Instantiate(HitParticle, transform.position, transform.rotation);
            Destroy(hitEffect, 2f);
            print("Hit");
            scoreMannger.AddScore();
            Destroy(collision.gameObject);
            isHit = true;
        }
        else
        {
            isHit = true;
            GameObject missEffect = Instantiate(MissParticle, transform.position, transform.rotation);
            Destroy(missEffect, 2f);
            print("Miss");
        }
        Destroy(gameObject);

    }
}
