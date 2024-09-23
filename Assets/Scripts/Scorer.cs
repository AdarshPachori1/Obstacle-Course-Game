using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    private int numHits;
    void Start()
    {
        numHits=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag!="Hit"){

            numHits++;
            Debug.Log("You've hit something. New total of things hit is "+numHits);
        }

    }
}
