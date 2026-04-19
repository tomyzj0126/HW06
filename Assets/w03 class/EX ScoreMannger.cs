using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EXScoreMannger : MonoBehaviour
{
    public TMP_Text text;
    int currentScore = 0;
    public int hitPionet = 1;

    public void AddScore()
    {
        currentScore += hitPionet;
        text.text =  currentScore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddScore();
        }
       
    }
}
