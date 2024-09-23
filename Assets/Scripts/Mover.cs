using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rb;
    private float speedScale = 10.0f;
    [SerializeField] float moveSpeed = 1.00f;

    // Start is called before the first frame update
    void Start()
    {
        initializeGlobals();
        printInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer(){
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveZ, 0, -1*moveX) * moveSpeed * speedScale * Time.deltaTime;

          // Moves if no collision
        if (!Physics.Raycast(transform.position, move, move.magnitude))
        {
            
            rb.MovePosition(transform.position + move);
        }
    }

    void initializeGlobals(){
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }

    void printInstructions(){
        Debug.Log("Welcome to the obstacle course game.");
        Debug.Log("Move the player using the arrow keys or the wasd keys to move through the obstacle course.");
    }
}
