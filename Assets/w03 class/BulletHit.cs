using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
  
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Sphere")
            {
                Destroy(collision.gameObject);
            }

            //Destroy(gameObject);
        }
   }
