using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS2_Bullet_Class : MonoBehaviour
{
    private int bulletDamage;
    private bool isHit = false;

    // Start is called before the first frame update
    public void SetDamage(int aount)
    {  
        bulletDamage = aount; 
    
    
    }
        
    

    // Update is called once per frame
    private void OnCollisiomEnter(Collision collision)
    {
        if (isHit) return;
        if(collision.gameObject.CompareTag("Trget"))
        {
            isHit = true;
            Debug.Log("Hit Target ! Damage: " + bulletDamage);


        }
        Destroy(gameObject);
    }
   
}
