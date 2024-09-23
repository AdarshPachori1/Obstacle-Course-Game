using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    [SerializeField] float timeToWait = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled=false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait){
            meshRenderer.enabled=true;
            rigidBody.useGravity=true;
        }
    }

}
