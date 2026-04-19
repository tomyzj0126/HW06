using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXTargetSpawner : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        int childCount = transform.childCount;
        print ("Child Count: " + childCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            Vector3 randomPos = new Vector3(Random.Range(-15f, 15f), 0, Random.Range(-15f, 15f));


            Vector3 spwanPosition = transform.position + randomPos;
            Quaternion spawnRotation = Quaternion.LookRotation(Vector3.back);
            GameObject clone = Instantiate(target, spwanPosition, spawnRotation);
            clone.transform.SetParent(transform);
        };

    }
}
